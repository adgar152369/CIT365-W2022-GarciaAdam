namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        private Button exitButton;
        private Button viewQuotesButton;
        private Button displayQuoteButton;
        private Button addQuoteButton;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void addQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.Tag = this;
            addQuote.Show(this);
            this.Hide();
        }

        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.viewQuotesButton = new System.Windows.Forms.Button();
            this.displayQuoteButton = new System.Windows.Forms.Button();
            this.addQuoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(378, 354);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 46);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // viewQuotesButton
            // 
            this.viewQuotesButton.Location = new System.Drawing.Point(328, 265);
            this.viewQuotesButton.Name = "viewQuotesButton";
            this.viewQuotesButton.Size = new System.Drawing.Size(200, 46);
            this.viewQuotesButton.TabIndex = 6;
            this.viewQuotesButton.Text = "View All Quotes";
            this.viewQuotesButton.UseVisualStyleBackColor = true;
            this.viewQuotesButton.Click += new System.EventHandler(this.viewQuotesButton_Click);
            // 
            // displayQuoteButton
            // 
            this.displayQuoteButton.Location = new System.Drawing.Point(328, 172);
            this.displayQuoteButton.Name = "displayQuoteButton";
            this.displayQuoteButton.Size = new System.Drawing.Size(200, 46);
            this.displayQuoteButton.TabIndex = 5;
            this.displayQuoteButton.Text = "Search Quotes";
            this.displayQuoteButton.UseVisualStyleBackColor = true;
            this.displayQuoteButton.Click += new System.EventHandler(this.displayQuoteButton_Click);
            // 
            // addQuoteButton
            // 
            this.addQuoteButton.Location = new System.Drawing.Point(328, 82);
            this.addQuoteButton.Name = "addQuoteButton";
            this.addQuoteButton.Size = new System.Drawing.Size(200, 46);
            this.addQuoteButton.TabIndex = 4;
            this.addQuoteButton.Text = "Add Quotes";
            this.addQuoteButton.UseVisualStyleBackColor = true;
            this.addQuoteButton.Click += new System.EventHandler(this.addQuoteButton_Click);
            // 
            // MainMenu
            // 
            this.ClientSize = new System.Drawing.Size(587, 476);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.viewQuotesButton);
            this.Controls.Add(this.displayQuoteButton);
            this.Controls.Add(this.addQuoteButton);
            this.Name = "MainMenu";
            this.ResumeLayout(false);

        }

        private void displayQuoteButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuote = new SearchQuotes();
            searchQuote.Tag = this;
            searchQuote.Show(this);
            this.Hide();
        }

        private void viewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuotes = new ViewAllQuotes();
            viewQuotes.Tag = this;
            viewQuotes.Show(this);
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}