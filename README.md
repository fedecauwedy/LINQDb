# LINQDb
Questo progetto ha lo scopo di visualizzare i dati di una tabella DB\
1. Inizialmente è necessario creare un cartella nominata nel modo corretto e successivamente aprirla su visual studio code\
2. Per lanciare un nuovo programma bisogna aprire il terminale e digitare "dotnet new console"\
3. scaricare l'estensione SQLite ![image](https://github.com/fedecauwedy/LINQDb/assets/116791048/4df2a91a-a3a0-491c-a27d-f94736102b8a)

4. successivamente bisogna scaricare il file al seguente link: https://www.sqlitetutorial.net/sqlite-sample-database/
5. inserire il file scaricato nella cartella di lavoro 
6. prima di procedere con la scrittura del codice è necessario aggiungere la libreria sqlite, per farlo occore andare nel temrminale \
7. e scrivere: 'dotnet add package sqlite-net-pcl'\
8. ora si può procedere con la scrittura del codice\
9. per visualizzare gli artisti in ordine la riga di codice da scrivere è la seguente:
###
   var temporanea = tblArtists.OrderByDescending(x=> x.Name).Max(y => y.ArtistId);
###

