using System.Collections;
using System.Collections.Generic;

public class Page {
    public string Title { get; set; }
    public string Text { get; set; }

    public List<string> Pages { get; set; }

    private static List<Page> _pageList = null;

    public static Page RandomPage;

    public static int CurrentPage1 = 0;
    public static int CurrentPage2 = 1;

    public static Page GetRandomPage() {
        List<Page> pageList = Page.PageList;

        int num = UnityEngine.Random.Range(0, pageList.Count);
        Page pg = pageList[num];
        pg.Pages = new List<string>();

        string[] words = pg.Text.Split(' ');
        //put 7 words on each page
        string page = "";
        int wordCount = 0;

        foreach (string word in words) {
            wordCount++;
            if (wordCount > 6) {
                pg.Pages.Add(page);
                page = "";
                wordCount = 0;
            }
            page += string.Format("{0} ", word);
        }

        pg.Pages.Add(page);

        RandomPage = pg;

        return pg;
    }

    public static List<Page> PageList {
        get {
            if (_pageList == null) {
                _pageList = new List<Page>();

                _pageList.Add(new Page
                {   //1
                    Title = "Hello",
                    Text = "Welcome to Etiqa FlipBook. This is the new feature that was added to make the staffs easier to flip the book and any PDF files that will be added here."
                });

                _pageList.Add(new Page
                {   //2
                    Title = "Good day",
                    Text = "You are able to see the various of information about Etiqa. Let's go to the next journey of knowing the history and a bit of policies about Etiqa!"
                });

                _pageList.Add(new Page
                {   //3
                    Title = "Wow",
                    Text = "You made it! Congratulations for finishing this flipbook. Now you can go to the projector for new information about the departments and existing staffs with their details."
                });
            }

            return _pageList;
        }
    }
}
