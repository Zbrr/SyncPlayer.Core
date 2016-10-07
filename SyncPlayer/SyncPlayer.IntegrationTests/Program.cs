using SyncPlayer.Common.Contracts;
using SyncPlayer.Domain;
using System;

namespace SyncPlayer.IntegrationTests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Search for: ");

            IFileFinderFacade fileFinderFacade = new FileFinderFacade();

            var songToSearch = Console.ReadLine();

            Console.WriteLine("Searching... ");

            var songs = fileFinderFacade.FindAudioFileAsync(songToSearch).Result;

            foreach (var audioFileDto in songs)
            {
                Console.WriteLine(audioFileDto.Url);
            }

            Console.ReadLine();
        }
    }
}
