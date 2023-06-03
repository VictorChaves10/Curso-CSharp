using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExStringBuilder.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Coment1> Comments { get; set; } = new List<Coment1>();
        
        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Coment1 coment) { Comments.Add(coment); }

        public void RemoveComment(Coment1 coment) {  Comments.Remove(coment); }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine(Title);
            sb.AppendLine($"{Likes} Likes - {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine(Content);

            foreach(Coment1 coment in Comments)
            {
                sb.AppendLine(coment.Text);
            }
            return sb.ToString();
        }
    }
}
