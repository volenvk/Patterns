namespace DesignPatterns.Mediator
{
    public class ManagerMediator : BaseMediator
    {
        public BaseColleague Customer => new CustomerColleague(this);
        public BaseColleague Programmer => new ProgrammerColleague(this);
        public BaseColleague QA => new QaColleague(this);
        
        public override void Send(BaseColleague baseColleague, string msg)
        {
            // если отправитель - заказчик, значит есть новый заказ
            // отправляем сообщение программисту - выполнить заказ
            if (Customer == baseColleague)
                Programmer.DoSomethingColleague(msg);
            
            // если отправитель - программист, то можно приступать к тестированию
            // отправляем сообщение тестеру
            if (Programmer == baseColleague)
                QA.DoSomethingColleague(msg);
            
            // если отправитель - тест, значит продукт готов
            // отправляем сообщение заказчику
            if (QA == baseColleague)
                Customer.DoSomethingColleague(msg);
        }
    }
}