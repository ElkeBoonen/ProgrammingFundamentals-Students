using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace FRONTEND___DSPS
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            RestClient client = new RestClient();
            //you can use your own backend new RestRequest("https://localhost:8000/Songs", Method.Get);
            RestRequest request = new RestRequest("http://webservies.be/eurosong/Songs", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);

            Console.WriteLine("SONGS - RESPONSE CONTENT AS JSON");
            Console.WriteLine(response.Content);

            Console.WriteLine("\n\nSONGS - RESPONSE CONTENT AFTER DESERIALIZING");
            List<Song> songs = JsonSerializer.Deserialize<List<Song>>(response.Content);
            Console.WriteLine(String.Join("\n",songs));

            Console.WriteLine("\n\nARTISTS");
            request = new RestRequest("http://webservies.be/eurosong/Artists", Method.Get);
            response = await client.ExecuteAsync(request);
            List<Artist> artists = JsonSerializer.Deserialize<List<Artist>>(response.Content);
            Console.WriteLine(String.Join("\n", artists));

            Console.WriteLine("\n\nADD A SONG");
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter artist: ");
            string artist = Console.ReadLine();

            string track = title + " " + artist;
            track = Uri.EscapeUriString(track);
            request = new RestRequest("https://spotify-scraper.p.rapidapi.com/v1/track/download/soundcloud?track=" + track,Method.Get);
            request.AddHeader("X-RapidAPI-Key", "KEY");
            request.AddHeader("X-RapidAPI-Host", "spotify-scraper.p.rapidapi.com");
            response = await client.ExecuteAsync(request);
            //Console.WriteLine(response.Content);
            dynamic data = JObject.Parse(response.Content);
            string spotify = data.spotifyTrack.shareUrl;

            Artist artistObject = artists.Find(x => x.name == artist);
            if (artistObject == null) //artist not found, add artist
            {
                artistObject = new Artist(artist);
                request = new RestRequest("http://webservies.be/eurosong/Artists", Method.Post);
                request.AddStringBody(JsonConvert.SerializeObject(artistObject), "application/json");
                response = await client.ExecuteAsync(request);
                artistObject = JsonSerializer.Deserialize<Artist>(response.Content);
            }


            Song song = new Song(title, artistObject.id, spotify);
            request = new RestRequest("http://webservies.be/eurosong/Songs", Method.Post);
            request.AddStringBody(JsonConvert.SerializeObject(song), "application/json");
            response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);

        }
    }
}
