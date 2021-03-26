using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public abstract class Account : IAccount
    {
        // Событие возникающее при выводе денег
        protected internal event AccountStateHandler Withdrawn;

        // Событие возникающее при добавление денег
        protected internal event AccountStateHandler Added;

        // Событие возникающее при открытии счета
        protected internal event AccountStateHandler Opened;

        // Событие возникающее при закрытии счета
        protected internal event AccountStateHandler Closed;

        // Событие возникающее при начисление процентов
        protected internal event AccountStateHandler Calculated;

        static int counter = 0;

        protected int _days = 0; // Время с момента открытия счета

        public Account(decimal sum, int percentage)
        {
            Sum = sum;
            Percentage = percentage;
            Id = ++counter;
        }


        public decimal Sum { get; private set; }

        public int Percentage { get; private set; }

        public int Id { get; private set; }

        private void CallEvent(AccountEventArgs e, AccountStateHandler handler)
        {
            if (e != null)
            {
                handler?.Invoke(this, e);
            }
        }

        // Вызов одтдельных события, для каждого события определяется свой виртуальный метод
        protected virtual void OnOpened(AccountEventArgs e)
        {
            CallEvent(e, Opened);
        }

        protected virtual void OnWithdrawn(AccountEventArgs e)
        {
            CallEvent(e, Withdrawn);
        }

        protected virtual void OnClosed(AccountEventArgs e)
        {
            CallEvent(e, Closed);
        }

        protected virtual void OnAdded(AccountEventArgs e)
        {
            CallEvent(e, Added);
        }

        protected virtual void OnCalculated(AccountEventArgs e)
        {
            CallEvent(e, Calculated);
        }

        public virtual void Put(decimal sum)
        {
            Sum += sum;
            OnAdded(new AccountEventArgs("На счет поступило " + sum, sum));
        }

        public virtual decimal Withdraw(decimal sum)
        {
            decimal result = 0;
            if (Sum >= sum)
            {
                Sum -= sum;
                result = sum;
                OnWithdrawn(new AccountEventArgs($"Сумма {sum} снята со счета {Id}", sum));
            }
            else
            {
                OnWithdrawn(new AccountEventArgs($"Недостаточно денег на счете {Id}", 0));
            }
            return result;
        }

        // Открытие счета 
        protected internal virtual void Open()
        {
            OnOpened(new AccountEventArgs($"Открыт новый счет! Id счета {Id}", Sum));
        }

        protected internal virtual void Close()
        {
            OnClosed(new AccountEventArgs($"Счет {Id} закрыт. Итоговая сумма: {Sum}", Sum));
        }

        protected internal virtual void IncrementDays()
        {
            _days++;
        }

        protected internal virtual void Calculate()
        {
            decimal increment = Sum * Percentage / 100;
            Sum = Sum + increment;
            OnCalculated(new AccountEventArgs($"Начислены проценты в размере: {increment}", increment));
        }

    }
}
