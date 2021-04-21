namespace BuildPatterns.Builder
{
    using System.Text;

    public class VacancyBuilder
    {
        private readonly StringBuilder _text;

        public VacancyBuilder()
        {
            _text = new StringBuilder();
        }


        public VacancyBuilder Add(string str)
        {
            _text.Append(str);
            return this;
        }

        private void addHeadder()
        {
            _text.Append("We looking for");
            _text.AppendLine();
        }
        
        private void AddLorem()
        {
            _text.Append("We looking for");
            _text.AppendLine();
            _text.Append("2+ years of experience in AngularJS.");
            _text.AppendLine();
            _text.Append("Experience in Angular JS (v1, v2, v4 v5+).");
            _text.AppendLine();
            _text.Append("Experience creating front end applications using HTML5, Angular, LESS/SASS is essential.");
            _text.AppendLine();
            _text.Append("Must have experience with developing services and directives.");
            _text.AppendLine();
            _text.Append("Must have strong Javascript fundamental knowledge.");
            _text.AppendLine();
            _text.Append("Familiarity with end-user prototype and usability testing.");
            _text.AppendLine();
            _text.Append("Keeps track of project as per Software Development Life Cycle.");
            _text.AppendLine();
            _text.Append("Should be able to understand and effectively use the available memory and space for web applications.");
            _text.AppendLine();
            _text.Append("Should be able to work with client on engagement.");
            _text.AppendLine();
            _text.Append("Should have good verbal & written communication skills.");
            _text.AppendLine();
            _text.Append("Should be able to work on the Agile methodology.");
            _text.AppendLine();
        }
    }
}