namespace _2._5_dars;

public class Book
{
	private string title;

	public  string Title
	{
		get { return title; }
		set { title = value; }
	}

	private string  author;

	public string  Author
	{
		get { return author; }
		set { author = value; }
	}

	public Book(string title, string author)
	{
		Title = title;
		Author = author;
	}
}
