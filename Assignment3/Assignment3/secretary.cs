using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class secretary
    {
        public int SecId { get; private set; }
        public string SecName { get; private set; }
        public string SecPassword { get; private set; }

        int[] games = new int[100];
        int[] movies = new int[100];
        int[] books = new int[100];

        public void AddGames( int id )
        {
            for(int i = 0; i < games.Length; i++)
            {
                games[i] = id;
            }
        }
        public void AddMovies
            for (int i = 0; i < games.Length; i++)
            {
                movies[i] = id;
            }
        }
        public void AddGames(int id)
        {
            for (int i = 0; i < games.Length; i++)
            {
                games[i] = id;
            }
        }
    }
}
