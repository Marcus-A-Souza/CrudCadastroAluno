Fiz um CRUD uma tela de cadastro usando visual studio, criei um projeto para armazenar dados de um cliente, como Nome, Telefone e Email. esse projeto ainda não está finalizado, meu intuito é ao longo da semana acrescentar mais funções ao CRUD até deixa-lo bem robusto. usei um Framework do ASP.NET CORE, para desenvolver uma aplicação. comecei criando uma classe dentro do Model usando recursos como TABLE,COLUMN E DISPLAY para criar minha tabela com as informações que desejo ter no CRUD. depois criei o CONTEXTO através de uma classe contexto herdando Dbcontext para poder validar e filtrar os resultados da minha aplicação. em seguida através do builder.Services adicionali o Dbcontext e logo depois fiz referência a conexão com o banco de dados SQL server. depois de fazer isso executei o comando Controlador clicando com o direito acima do controlador para gerar todos os drivers relacionados à minha aplicação. e por último e não menos importante fiz a migração através do console do gerenciador de pacotes usando os comandos Add-migration inicial criação-context contexto e em seguida o Update-Database-context contexto para fazer toda a conexão da minha aplicação. foi gerado esse CRUD
