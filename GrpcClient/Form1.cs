using Grpc.Net.Client;
using GrpcServer;

namespace GrpcClient
{
    public partial class Form1 : Form
    {
        private const string Address = "https://localhost:7114/";
        private readonly Reverser.ReverserClient _client;

        public Form1()
        {
            InitializeComponent();

            var channel = GrpcChannel.ForAddress(Address);
            _client = new Reverser.ReverserClient(channel);
        }

        private async void reverseBtn_Click(object sender, EventArgs e)
        {
            var textToReverse = new ReverserRequest { TextToReverse = inputTextBox.Text };

            var reply = await ReverserReply(textToReverse);

            outputReversedOnlyWords.Text = reply.ReversedOnlyWords;
            outputReversedAllText.Text = reply.ReversedAllText;
        }

        private async Task<ReverserReply> ReverserReply(ReverserRequest textToReverse)
        {
            var reply = await _client.GetReversedTextAsync(textToReverse);
            return reply;
        }
    }
}
