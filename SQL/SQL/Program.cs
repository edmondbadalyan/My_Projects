using System.Collections;
using System.Data;
using System.Data.SqlClient;
namespace SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDbConnection connection = new SqlConnection(@"Data Source=(localdb)\.;Integrated Security=True");
            connection.Open();

            IDbCommand command = connection.CreateCommand();
            command.CommandText = @"
                SELECT 
                s.ID AS SongID, 
                s.TITLE AS SongTitle, 
                  s.RATING AS SongRating, 
                 a.ID AS ArtistID, 
                 a.NAME AS ArtistName
FROM 
    SONGS s
JOIN 
    song_artists sa ON s.ID = sa.SONGID
JOIN 
    artists a ON sa.NAMEID = a.ID;";
                                              

            IDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string title = reader.GetString(1);
                int? rating = reader.GetByte(2);
                Console.WriteLine($"{id} {title} {rating}");
            }



        }
    }
}
//у меня есть таблицы artists cо столбцами, ID и NAME
//есть таблица song_artists со столбцами ID SONGID NAMEID
//еще таблица SONGS  cо столбцами ID TITLE RATING
//теперь надо отобразить данные их соединённых таблиц: songs + artists + song_artists.Используйте JOIN.