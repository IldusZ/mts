using System;

namespace MTSTask.Models
{
    /// <summary>
    /// События на АТС
    /// </summary>
    public class CallEvent
    {
        /// <summary>
        /// Уникальный идентификатор вызова
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Тип вызова (начало звонка, ответ оператора, завершение звонка)
        /// </summary>
        public EventType EventType { get; set; }

        /// <summary>
        /// Номер абонента инициализировавшего вызов
        /// </summary>
        public string PhoneFrom { get; set; }

        /// <summary>
        /// Номер назначения 
        /// </summary>
        public string PhoneTo { get; set; }

        /// <summary>
        /// Время вызова
        /// </summary>
        public DateTime CallTime { get; set; }
    }

    /// <summary>
    /// Типы вызовов
    /// </summary>
    public enum EventType
    {
        /// <summary>
        /// Начало звонка
        /// </summary>
        Call = 1,

        /// <summary>
        /// Ответ оператора на вызов
        /// </summary>
        Answer = 2,

        /// <summary>
        /// Завершение звонка
        /// </summary>
        HangUp = 3
    }
}