using Dapper;
using MySql.Data.MySqlClient;
using NS.Domain.Contracts.Repositories;
using NS.Domain.Models.View;
using NS.Infra.Context;
using System.Collections.Generic;
using System.Data;

namespace NS.Infra.Repositories
{
    public class MainRepository : IMainRepository
    {
        private ContextCore _ctxCore;
        private readonly IConnectionFactory _connectionFactory;

        public MainRepository(IConnectionFactory connection)
        {
            _connectionFactory = connection;
        }

        public List<PostsVM> GetPosts()
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionFactory.ConnectionString))
            {
                string query = ("SELECT * FROM (SELECT ID, post_author, post_date, post_content, post_title, post_name, guid, meta_value ");
                query += ("FROM nextseasonprd.ns_posts AS TB1 ");
                query += ("INNER JOIN nextseasonprd.ns_postmeta AS TB2 ON TB1.ID = TB2.post_id ");
                query += ("WHERE post_status = 'publish' AND ping_status = 'open' AND meta_key = '_thumbnail_id') AS Q1 ");
                query += ("INNER JOIN  ");
                query += ("(SELECT ID id_post_img, guid link_imagem FROM nextseasonprd.ns_posts WHERE post_type = 'attachment') ");
                query += ("AS Q2 ON Q1.meta_value = Q2.id_post_img ");
                query += ("ORDER BY 1 DESC;");

                return conn.Query<PostsVM>(
                    query,
                   commandType: CommandType.Text).AsList();
            }
        }
    }
}