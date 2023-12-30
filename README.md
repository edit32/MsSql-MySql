# MsSql-MySql
Progetto per l'uso contemporaneo di DB Ms SQL e MySQL

Progetto nato per far coesistere connessioni a Sql Server (e derivati) e MySQL. Ho utilizzato la tabella comuni scaricata da Garda Informatica (https://www.gardainformatica.it/database-comuni-italiani) su Licenza MIT

Anche questo progetto segue la stessa linea di Licenza

Nel progetto è stato incluso il localDb DbMsSQL.mdf mentre per il Db MySQL, io ho usato UniServer Zero da cui ho estratto lo script per creare il DB e la tabella speculare da cui attingere i dati. Su MySql ricordatevi di configurare l'utente e sistemare la stringa di connessione in App.Config.
