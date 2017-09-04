```C#
public class Question
{
	public Question()
	{
	          Keywords = new HashSet<Keyword>();
	}

	[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
	public int QuestionId { get; set; }

	public string QuestionText { get; set; }
	public string PhotoUrl { get; set; }
	public int SortOrder { get; set; }
	public string PdfUrl { get; set; }
	public string VideoUrl { get; set; }

	public ICollection<Keyword> Keywords { get; set; }
}

public class Keyword
{
	public Keyword()
	{
		Questions = new HashSet<Question>();
	}

	[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
	public int KeywordId { get; set; }

	public string Description { get; set; }
	public ICollection<Question> Questions { get; set; }
}
```
My code to insert data into these classes:

```C#
using (var db = new NarrLibContext())
{
	var question = new Question
	{
		PdfUrl = "www.pdf.com",
		PhotoUrl = "www.photo.com",
		QuestionText = "What is the definition and importance of the research?",
		VideoUrl = "www.video.com",
	};

	var k1 = new Keyword { Description = "Adaptation" };
	var k2 = new Keyword { Description = "Champion" };
	var k3 = new Keyword { Description = "Dissemination" };

	question.Keywords.Add(k1);
	question.Keywords.Add(k2);
	question.Keywords.Add(k3);

	db.Questions.Add(question);
	int recordsAffected = db.SaveChanges();

}
```
