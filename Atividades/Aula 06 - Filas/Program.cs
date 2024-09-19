using Aula_06___Filas;


// Uma fila é a estrutura de dados que pode ser aplicada para representar a fila de atendimento da cantina;
// As pessoas que chegam entram no final da fila. E as primeiras que chegaram são as primeiras a serem atendidas;

// A função ENQUEUE é responsavel por adicionar novos elementos a fila;
// A função DEQUEUE remove elementos da fila;

// Desta forma, obedece o principio do FIFO;
// First In, First Out -> Primeiro que entra / Primeiro que sai;



Random random = new Random();

CallCenter center = new ();
center.call(1234);
center.call(1369);
center.call(2468);
center.call(1478);


while(center.AreWaitCalls())
{
    Thread.Sleep(3000);
    IncomingCall call = center.Answer("Silvio");
    Console.WriteLine( @$"{DateTime.Now:HH:mm:ss} 
    Chamado: #{call.Id}
    De: {call.ClientId}
    Atendido por: {call.Consultant}");
        
    Thread.Sleep(random.Next(1000, 10000));
    center.End(call);
    Console.WriteLine( @$"Chamado: {call.Id}
    Encerrado às: {call.EndTime}");
};