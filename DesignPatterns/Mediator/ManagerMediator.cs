namespace DesignPatterns.Mediator
{
    public class ManagerMediator : Mediator
    {
        public Colleague Customer => new CustomerColleague(this);
        public Colleague Programmer => new ProgrammerColleague(this);
        public Colleague QA => new QAColleague(this);
        
        public override void Send(Colleague colleague, string msg)
        {
            // если отправитель - заказчик, значит есть новый заказ
            // отправляем сообщение программисту - выполнить заказ
            if (Customer == colleague)
                Programmer.DoSomethingColleague(msg);
            
            // если отправитель - программист, то можно приступать к тестированию
            // отправляем сообщение тестеру
            if (Programmer == colleague)
                QA.DoSomethingColleague(msg);
            
            // если отправитель - тест, значит продукт готов
            // отправляем сообщение заказчику
            if (QA == colleague)
                Customer.DoSomethingColleague(msg);
        }
    }
}