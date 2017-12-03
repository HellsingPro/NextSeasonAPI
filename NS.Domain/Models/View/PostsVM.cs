using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.Domain.Models.View
{
    public class PostsVM
    {
        public int ID { get; set; }
        public int post_author { get; set; }
        public DateTime post_date { get; set; }
        public string post_content { get; set; }
        public string post_title { get; set; }
        public string post_name { get; set; }
        public string guid { get; set; }
        public int meta_value { get; set; }
        public int id_post_img { get; set; }
        public string link_imagem { get; set; }
    }
}
