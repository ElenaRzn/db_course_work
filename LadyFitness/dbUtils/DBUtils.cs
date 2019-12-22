using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using LadyFitness.vo;

namespace LadyFitness.dbUtils
{
    public class DBUtils
    {
        private SqlConnection OpenConnection()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = "Data Source=LENAPC\\SQLEXPRESS;"
                                   + "Initial Catalog=Fitness2;"
                                   + "Integrated Security=true;";
            connection.Open();
            return connection;
        }

        private SqlConnection PrepareConnection()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = "Data Source=LENAPC\\SQLEXPRESS;"
                                   + "Initial Catalog=Fitness2;"
                                   + "Integrated Security=true;";
            return connection;
        }

        private void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }


        public void ExecuteCommand()
        {
            var connection = OpenConnection();


            CloseConnection(connection);
        }



        public int AddClient(String name, String surname, String secondName, String passport, DateTime birthday)
        {
            var connection = OpenConnection();
            var command = connection.CreateCommand();

            command.CommandText = "EXECUTE AddClient @Name, @Surname, @SecondName, @Passport, @Birthday, @IdClient OUTPUT";

            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = surname;
            command.Parameters.Add("@SecondName", SqlDbType.NVarChar).Value = secondName;
            command.Parameters.Add("@Passport", SqlDbType.NVarChar).Value = passport;
            command.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = birthday;
            command.Parameters.Add("@IdClient", SqlDbType.Int);
            command.Parameters["@IdClient"].Direction = ParameterDirection.Output;

            var result = command.ExecuteNonQuery();

            CloseConnection(connection);

            Console.WriteLine("Add Client Success " + result);
            return Convert.ToInt32(command.Parameters["@IdClient"].Value);

        }
        /// <summary>
        /// Поиск клиента по номеру карты.
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <returns></returns>
        public List<Client> searchClient(string cardNumber)
        {
            var connection = PrepareConnection();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Client INNER JOIN Card ON Client.IDClient = Card.IDClient " + "" +
                "WHERE IDCard = @idCard";
            command.Parameters.Add("@idCard", SqlDbType.NVarChar, 64);
            command.Parameters["@idCard"].Value = cardNumber;
            
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Client> clients = new List<Client>();
            while (reader.Read())
            {
                clients.Add(new Client((int)reader["IDClient"], reader["Name"].ToString(), reader["Surname"].ToString(),
                    reader["SecondName"].ToString(), reader["passport"].ToString(), (DateTime)reader["Birthday"]));

            }

            reader.Close();
            CloseConnection(connection);

            return clients;
        }

        /// <summary>
        /// Поиск клиента по ФИО
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="secondName"></param>
        /// <returns></returns>
        public List<Client> searchClient(string surname, string name, string secondName)
        {
            var connection = PrepareConnection();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Client WHERE SURNAME LIKE @surname AND NAME LIKE @name AND SECONDNAME LIKE @secondName";
            command.Parameters.Add("@surname", SqlDbType.NVarChar, 64);
            command.Parameters["@surname"].Value = "%" + surname + "%";
            command.Parameters.Add("@name", SqlDbType.NVarChar, 64);
            command.Parameters["@name"].Value = "%" + name + "%";
            command.Parameters.Add("@secondName", SqlDbType.NVarChar, 64);
            command.Parameters["@secondName"].Value = "%" + secondName + "%";

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Client> clients = new List<Client>();
            while (reader.Read())
            {
                clients.Add(new Client((int)reader["IDClient"], reader["Name"].ToString(), reader["Surname"].ToString(),
                    reader["SecondName"].ToString(), reader["passport"].ToString(), (DateTime)reader["Birthday"]));
                
            }
            
            reader.Close();
            CloseConnection(connection);
            
            return clients;
        }


        /// <summary>
        /// Добавить карту.
        /// </summary>
        public void AddCard(int idClient, int idCardType, DateTime startDate, int months)
        {
            var query = "INSERT INTO CARD(IdClient, IDCardType, StartDate, Months) VALUES(@IdClient, @IDCardType, @StartDate, @Months)";
            var connection = PrepareConnection();
            var command = connection.CreateCommand();
            command.CommandText = query;

            command.Parameters.AddWithValue("@IdClient", idClient);
            command.Parameters.AddWithValue("@IDCardType", idCardType);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@Months", months);

            connection.Open();
            command.ExecuteNonQuery();

            CloseConnection(connection);


        }

        public Card GetClientCard(int idClient)
        {
            var connection = PrepareConnection();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Card WHERE IDClient = @IdClient ORDER BY StartDate";
            command.Parameters.AddWithValue("@IdClient", idClient);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            Card card = null;
            while (reader.Read())
            {
                card = new Card(Convert.ToInt32(reader["IDCard"]), Convert.ToInt32(reader["IDClient"]),
                    Convert.ToInt32(reader["IDCardType"]), Convert.ToDateTime(reader["StartDate"]), Convert.ToInt32(reader["Months"]));
            }
            reader.Close();
            CloseConnection(connection);

            return card;
        }

        public List<Include> GetInclude(int cardId)
        {
            var connection = PrepareConnection();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT Class.IDClass as IDClass, IdCard, MaxPersonalCount,  RestPersonalCount, " + 
                " Class.Name as Class, Trainer.Name  as Trainer FROM(Include INNER JOIN Class " + 
                "ON Include.IDClass = Class.IDClass) INNER JOIN Trainer on Class.IDTrainer = Trainer.IDTrainer " +
                "WHERE IDCard = @IDCard"; 
            command.Parameters.AddWithValue("@IDCard", cardId);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<Include> items = new List<Include>();
            if(items != null)
            {
                while (reader.Read())
                    items.Add(new Include(Convert.ToInt32(reader["IDClass"]), Convert.ToInt32(reader["IdCard"]),
                       Convert.ToInt32(reader["MaxPersonalCount"]), Convert.ToInt32(reader["RestPersonalCount"]), 
                       reader["Class"].ToString(), reader["Trainer"].ToString()));
            }
            reader.Close();

            return items;
        }

        public List<Class> GetClass(int classId)
        {
            var connection = PrepareConnection();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Class WHERE IDClass = @IDClass";
            command.Parameters.AddWithValue("@IDClass", classId);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<Class> items = new List<Class>();
            while (reader.Read())
                items.Add(new Class(Convert.ToInt32(reader["IDClass"]), Convert.ToInt32(reader["IDTrainer"]),
                    Convert.ToInt32(reader["IDRoom"]), Convert.ToInt32(reader["DayNumber"]), reader["Name"].ToString(),
                Convert.ToDateTime(reader["Time"])));
            reader.Close();

            return items;
        }

        public void AddPersonal(int idCard, int idTrainer, int idRoom, int weekDay, String trainName, 
            DateTime time, int cost, int count)
        {
            // AddPersonalClassForExistingClient
            var connection = OpenConnection();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddPersonalClassForExistingClient";
            command.Parameters.Add("@IDCard", SqlDbType.Int).Value = idCard;
            command.Parameters.Add("@IDTrainer", SqlDbType.Int).Value = idTrainer;
            command.Parameters.Add("@IDRoom", SqlDbType.Int).Value = idRoom;
            command.Parameters.Add("@WeekDay", SqlDbType.Int).Value = weekDay;
            command.Parameters.Add("@TrainName", SqlDbType.NVarChar, 64);
            command.Parameters["@TrainName"].Value = trainName;
            command.Parameters.Add("@Time", SqlDbType.DateTime).Value = time;
            command.Parameters.Add("@Cost", SqlDbType.Int).Value = cost;
            command.Parameters.Add("@Count", SqlDbType.Int).Value = count;
            command.ExecuteNonQuery();

            CloseConnection(connection);

        }

        public List<Timetable> GetTimetable(int dayNumber)
        {
            var connection = PrepareConnection();
            SqlCommand command = connection.CreateCommand();
            if(dayNumber == 0)
            {
                command.CommandText = "SELECT DayNumber, Room.TypeRoom, Class.Name as ClassName, Trainer.Name as TrainName, " +
                                    "Room.TypeRoom as Room, Class.Time as ClassTime FROM (Class INNER JOIN Trainer ON " +
                                    "Class.IDTrainer = Trainer.IDTrainer) INNER JOIN Room ON Class.IDRoom = Room.IDRoom " +
                                    "ORDER BY DayNumber";
            } else
            {
                command.CommandText = "SELECT DayNumber, Room.TypeRoom, Class.Name as ClassName, Trainer.Name as TrainName, " +
                                    "Room.TypeRoom as Room, Class.Time as ClassTime FROM (Class INNER JOIN Trainer ON " +
                                    "Class.IDTrainer = Trainer.IDTrainer) INNER JOIN Room ON Class.IDRoom = Room.IDRoom WERE DayNumber = @dayNumber "; 
                command.Parameters.Add("@IDCard", SqlDbType.Int).Value = dayNumber;
            }
            
            
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<Timetable> items = new List<Timetable>();
            while (reader.Read())
                items.Add(new Timetable(Convert.ToInt32(reader["DayNumber"]), reader["ClassName"].ToString(), 
                    reader["TrainName"].ToString(), reader["Room"].ToString(), Convert.ToDateTime(reader["ClassTime"])));
            reader.Close();

            return items;
        }

    }
}
