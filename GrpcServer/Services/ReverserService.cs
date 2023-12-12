using Grpc.Core;

namespace GrpcServer.Services
{
    public class ReverserService : Reverser.ReverserBase
    {
        private readonly ILogger<ReverserService> _logger;

        public ReverserService(ILogger<ReverserService> logger)
        {
            _logger = logger;
        }

        public override Task<ReverserReply> GetReversedText(ReverserRequest request, ServerCallContext context)
        {
            var reverserOutput = new ReverserReply
            {
                ReversedOnlyWords = ReverseOnlyWords(request.TextToReverse),
                ReversedAllText = ReverseAllChars(request.TextToReverse)
            };

            return Task.FromResult(reverserOutput);
        }
        
        public string ReverseOnlyWords(string contextToReverse)
        {
            var words = contextToReverse.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        public string ReverseAllChars(string contextToReverse)
        {
            var chars = contextToReverse.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
