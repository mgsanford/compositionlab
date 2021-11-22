namespace complab
{
    public class Book
    {
        
        private string isbn;
        private string title;
        private Author Author;

        public Book(string tempIsbn, string tempTitle, Author tempAuthor)
        {
            this.isbn = tempIsbn;
            this.title = tempTitle;
            this.Author = tempAuthor;
            
        }
        public string GetIsbn()
        {
            return isbn;
        }
        public void SetIsbn(string tempIsbn)
        {
            this.isbn = tempIsbn;
        }
        public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string TempTitle)
        {
            this.title = TempTitle;
        }
        public Author GetAuthor()
        {
            return Author;
        }
        public void SetAuthor(Author author)
        {
            this.Author = author;
        }
        public override string ToString()
        {
           return $"{"isbn = " + isbn}, {"title = " + title}, {Author.ToString()}";
           
        }
    }
}