using System;
namespace Inheritance2
{
	public class ImagePost : Post
	{
		public string ImageURL { get; set; }




		public ImagePost() //thanks to this empty constructor we inherience from base 
		{
		}

		public ImagePost(string title, bool ispublic, string imageURL, string sendby)
		{
			//inherited from Post
			this.ID = GetNextID();
			this.Title = title;
			this.SendBy = sendby;
			this.IsPublic = ispublic;

			//member of ImagePost, but not of Post
			this.ImageURL = imageURL;
		}

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.SendBy} - {this.ImageURL}");
        }
    }
}

