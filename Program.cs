// See https://aka.ms/new-console-template for more information
using SQLite;

// 27/04/23
// Connessione al db
SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
var tblArtists = cn1.Query<Artist>("select * from Artists");
Console.WriteLine($" in questa tabella ci sono {tblArtists.Count} record!");

// Language INtegrate Query
// LINQ
/*
// 4/05/23
int x = 0;
Artist[] vect = new string[tblArtists.Count];

while(x<tblArtists.Count)
{
    vect[x] = tblArtists[x].Name;
    x++;
}
*/
var temporanea = tblArtists.OrderByDescending(x=> x.Name).Max(y => y.ArtistId); // se c'è => significa che c'è una lambda exprection
         
foreach( var artista in tblArtists)
{
    Console.WriteLine($"{artista.Name}");
}
Console.WriteLine($"{temporanea}");

//---------------------------------
// fine del main.... inizio delle dichiarazioni
//---------------------------------
public class Artist
{
    public int ArtistId{get;set;}
    public string Name{get;set;}
}
