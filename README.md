# LINQDb
Questo progetto ha lo scopo di visualizzare i dati di una tabella DB\
1. Inizialmente è necessario creare un cartella nominata nel modo corretto e successivamente aprirla su visual studio code\
2. Per lanciare un nuovo programma bisogna aprire il terminale e digitare "dotnet new console"\
3. scaricare l'estensione SQLite ![image](https://github.com/fedecauwedy/LINQDb/assets/116791048/4df2a91a-a3a0-491c-a27d-f94736102b8a)

4. successivamente bisogna scaricare il file al seguente link: https://www.sqlitetutorial.net/sqlite-sample-database/
5. inserire il file scaricato nella cartella di lavoro 
6. prima di procedere con la scrittura del codice è necessario aggiungere la libreria sqlite, per farlo occore andare nel temrminale \
7. e scrivere: 'dotnet add package sqlite-net-pcl'\
8. nel file csproj comparirà il seguente codice: ![image](https://github.com/fedecauwedy/LINQDb/assets/116791048/02dfc3cc-c098-478b-bde5-5787d711cb63)\
9. ora si può procedere con la scrittura del codice\
10. per visualizzare gli artisti in ordine la riga di codice da scrivere è la seguente:
###
    var temporanea = tblArtists.OrderByDescending(x=> x.Name).Max(y => y.ArtistId);
###
11.  nella immagine qui allegata è mostrata una parte della tabella artists: ![image](https://github.com/fedecauwedy/LINQDb/assets/116791048/5c2d965f-fc33-4eb6-b806-33184b0c1b44)\
12. per aprirla bisogna seguire i seguenti passi: \
13. per prima cosa cliccare con il tasto desto sul file "chinook.db" e aprire il suo database, infine bastera digitare su "mostra tabella" e comparirà a schermo.



