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

        public void AddGames( int gameid )
        {
            for(int i = 0; i < games.Length; i++)
            {
                games[i] = gameid;
            }
        }
        public void AddMovies(int movieid) { 
            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = movieid;
            }
        }
        public void AddBooks(int bookid)
        {
            for (int i = 0; i < books.Length; i++)
            {
                books[i] = bookid;
            }
        }
    }
}
