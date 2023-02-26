using System;
namespace Inheritance2
{
	public class Post
	{
		private static int currentPost; //ID
		//properities
		protected int ID { set; get; }
		public string Title { set; get; }
		protected string SendBy { set; get; }
		protected bool IsPublic { set; get; }

		//default constructor if a deived class does not invoke a base class
		//constructor explicity, the default constructor id called imlicity

		public Post()
		{ 
			ID = 0;
			Title = "My first post";
			IsPublic = true;
			SendBy = "Justyna Malinowska";

		}

		//instance constructor with 3 parameters
		public Post(string title, bool ispublic,string sendby)
		{
			this.ID = GetNextID();
			this.Title = title;
			this.SendBy = sendby;
			this.IsPublic = ispublic;
		}

		protected int GetNextID()
		{
			return ++currentPost;
		}

		public void Update(string title, bool IsPublic)
		{
			this.Title = title;
			this.IsPublic = IsPublic;
		}

		//we are overriding wbudowana method w c#
		//to string- inherited method from System.Object
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.SendBy}");
        }
    }
}

