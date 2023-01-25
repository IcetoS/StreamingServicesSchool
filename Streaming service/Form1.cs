namespace Streaming_service
{
    public partial class Form1 : Form
    {
        BindingSource artistBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArtistsDAO artistsDAO = new ArtistsDAO();
            Artists a1 = new Artists
            {
                Id = 1,
                Title = "Frog song",
                Descrition = "This is a song about frogs",
                ArtistId = 1,
                ArtistName = "Frog singer",
                videoDurationSeconds = 600,
                publishDateMonth = 3
            };
            Artists a2 = new Artists
            {
                Id = 2,
                Title = "Frog song 2",
                Descrition = "This is a song about frogs number 2 ",
                ArtistId = 1,
                ArtistName = "Frog singer",
                videoDurationSeconds = 688,
                publishDateMonth = 6
            };
            Artists a3 = new Artists
            {
                Id = 3,
                Title = "Bird song",
                Descrition = "This is a song about birds",
                ArtistId = 2,
                ArtistName = "Bird singer",
                videoDurationSeconds = 378,
                publishDateMonth = 1
            };
            Artists a4 = new Artists
            {
                Id = 4,
                Title = "Bird song 2",
                Descrition = "This is a song about birds number 2",
                ArtistId = 2,
                ArtistName = "Bird singer",
                videoDurationSeconds = 398,
                publishDateMonth = 2
            };
            Artists a5 = new Artists
            {
                Id = 5,
                Title = "Bird song 3",
                Descrition = "This is a song about birds number 3",
                ArtistId = 2,
                ArtistName = "Bird singer",
                videoDurationSeconds = 208,
                publishDateMonth = 3
            };
            Artists a6 = new Artists
            {
                Id = 5,
                Title = "Bird song 4",
                Descrition = "This is a song about birds FINALE",
                ArtistId = 2,
                ArtistName = "Bird singer",
                videoDurationSeconds = 458,
                publishDateMonth = 4
            };

            artistsDAO.artists.Add(a1);
            artistsDAO.artists.Add(a2);
            artistsDAO.artists.Add(a3);
            artistsDAO.artists.Add(a4);
            artistsDAO.artists.Add(a5);

            artistBindingSource.DataSource = artistsDAO.artists;
            dataGridView1.DataSource = artistBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}