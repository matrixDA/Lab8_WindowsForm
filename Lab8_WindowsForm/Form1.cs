using System.Linq;

namespace Lab8_WindowsForm
{
    public partial class Form1 : Form
    {
        string filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                filename = ofd.FileName;
                txtBrowse.Text = filename.Split("\\").LastOrDefault();
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            lstBox1.Items.Clear();

            List<Task> tasks = new List<Task>();

            var wordTask = ReadBook(filename);
            tasks.Add(wordTask);
            await Task.WhenAll(tasks);
        }

        private async Task ReadBook(string fileN)
        {
            var lines = await Task.FromResult(File.ReadAllLinesAsync(fileN));
            var linesWithoutPunctuation = lines.Result.Where(x => x != string.Empty)
                .AsParallel()
                .Select(x => x.ToLower().Trim().Replace(",", "").Replace("*", "").Replace(".", ""));
            var arrayOfWords = linesWithoutPunctuation.SelectMany(x => x.Split(" "));
            Dictionary<string, int> dictionaryOfWords = new Dictionary<string, int>();
            foreach (var word in arrayOfWords)
            {
                if (dictionaryOfWords.ContainsKey(word))
                {
                    dictionaryOfWords[word]++;
                }
                else
                {
                    dictionaryOfWords.Add(word, 1);
                }
            }

            var top10 = dictionaryOfWords.Where(x => !string.IsNullOrWhiteSpace(x.Key)).OrderByDescending(x => x.Value).Take(10);
            foreach (var word in top10)
            {
                lstBox1.Items.Add(word.Key + " - " + word.Value);
            }
        }
    }
}