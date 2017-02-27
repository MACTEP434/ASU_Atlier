﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.АСУ_Ателье
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Заказ.
    /// </summary>
    // *** Start programmer edit section *** (Заказ CustomAttributes)

    // *** End programmer edit section *** (Заказ CustomAttributes)
    [BusinessServer("IIS.АСУ_Ателье.СерверБЛ, АСУ_Ателье(BusinessServers)", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnAllEvents)]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗаказE", new string[] {
            "КодЗаказа as \'Код заказа\'",
            "СтатусЗаказа as \'Статус заказа\'",
            "ДатаПоступления as \'Дата поступления\'",
            "ДатаЗакрытия as \'Дата закрытия\'",
            "Клиент as \'Клиент\'",
            "Модель",
            "Мастер",
            "Сумма"})]
    [MasterViewDefineAttribute("ЗаказE", "Клиент", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИОКлиента")]
    [MasterViewDefineAttribute("ЗаказE", "Модель", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "НазваниеМодели")]
    [MasterViewDefineAttribute("ЗаказE", "Мастер", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИОМастера")]
    [View("ЗаказL", new string[] {
            "КодЗаказа as \'Код заказа\'",
            "ДатаПоступления as \'Дата поступления\'",
            "ДатаЗакрытия as \'Дата закрытия\'",
            "СтатусЗаказа as \'Статус заказа\'",
            "Мастер.ФИОМастера as \'ФИО мастера\'",
            "Клиент.ФИОКлиента as \'ФИО клиента\'",
            "Сумма as \'Сумма заказа\'"})]
    public class Заказ : ICSSoft.STORMNET.DataObject
    {
        
        private int fКодЗаказа;
        
        private System.DateTime fДатаПоступления;
        
        private System.DateTime? fДатаЗакрытия;
        
        private IIS.АСУ_Ателье.tСтатусЗаказа fСтатусЗаказа = IIS.АСУ_Ателье.tСтатусЗаказа.ВРаботе;
        
        private decimal fСумма;
        
        private IIS.АСУ_Ателье.Клиент fКлиент;
        
        private IIS.АСУ_Ателье.МодельОдежды fМодель;
        
        private IIS.АСУ_Ателье.Цех fЦех;
        
        private IIS.АСУ_Ателье.Мастер fМастер;
        
        // *** Start programmer edit section *** (Заказ CustomMembers)

        // *** End programmer edit section *** (Заказ CustomMembers)

        
        /// <summary>
        /// КодЗаказа.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.КодЗаказа CustomAttributes)

        // *** End programmer edit section *** (Заказ.КодЗаказа CustomAttributes)
        [DisableInsertProperty(true)]
        [NotNull()]
        public virtual int КодЗаказа
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.КодЗаказа Get start)

                // *** End programmer edit section *** (Заказ.КодЗаказа Get start)
                int result = this.fКодЗаказа;
                // *** Start programmer edit section *** (Заказ.КодЗаказа Get end)

                // *** End programmer edit section *** (Заказ.КодЗаказа Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.КодЗаказа Set start)

                // *** End programmer edit section *** (Заказ.КодЗаказа Set start)
                this.fКодЗаказа = value;
                // *** Start programmer edit section *** (Заказ.КодЗаказа Set end)

                // *** End programmer edit section *** (Заказ.КодЗаказа Set end)
            }
        }
        
        /// <summary>
        /// ДатаПоступления.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.ДатаПоступления CustomAttributes)

        // *** End programmer edit section *** (Заказ.ДатаПоступления CustomAttributes)
        [NotNull()]
        public virtual System.DateTime ДатаПоступления
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.ДатаПоступления Get start)

                // *** End programmer edit section *** (Заказ.ДатаПоступления Get start)
                System.DateTime result = this.fДатаПоступления;
                // *** Start programmer edit section *** (Заказ.ДатаПоступления Get end)

                // *** End programmer edit section *** (Заказ.ДатаПоступления Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.ДатаПоступления Set start)

                // *** End programmer edit section *** (Заказ.ДатаПоступления Set start)
                this.fДатаПоступления = value;
                // *** Start programmer edit section *** (Заказ.ДатаПоступления Set end)

                // *** End programmer edit section *** (Заказ.ДатаПоступления Set end)
            }
        }
        
        /// <summary>
        /// ДатаЗакрытия.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.ДатаЗакрытия CustomAttributes)

        // *** End programmer edit section *** (Заказ.ДатаЗакрытия CustomAttributes)
        public virtual System.DateTime? ДатаЗакрытия
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.ДатаЗакрытия Get start)

                // *** End programmer edit section *** (Заказ.ДатаЗакрытия Get start)
                System.DateTime? result = this.fДатаЗакрытия;
                // *** Start programmer edit section *** (Заказ.ДатаЗакрытия Get end)

                // *** End programmer edit section *** (Заказ.ДатаЗакрытия Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.ДатаЗакрытия Set start)

                // *** End programmer edit section *** (Заказ.ДатаЗакрытия Set start)
                this.fДатаЗакрытия = value;
                // *** Start programmer edit section *** (Заказ.ДатаЗакрытия Set end)

                // *** End programmer edit section *** (Заказ.ДатаЗакрытия Set end)
            }
        }
        
        /// <summary>
        /// СтатусЗаказа.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.СтатусЗаказа CustomAttributes)

        // *** End programmer edit section *** (Заказ.СтатусЗаказа CustomAttributes)
        [NotNull()]
        public virtual IIS.АСУ_Ателье.tСтатусЗаказа СтатусЗаказа
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.СтатусЗаказа Get start)

                // *** End programmer edit section *** (Заказ.СтатусЗаказа Get start)
                IIS.АСУ_Ателье.tСтатусЗаказа result = this.fСтатусЗаказа;
                // *** Start programmer edit section *** (Заказ.СтатусЗаказа Get end)

                // *** End programmer edit section *** (Заказ.СтатусЗаказа Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.СтатусЗаказа Set start)

                // *** End programmer edit section *** (Заказ.СтатусЗаказа Set start)
                this.fСтатусЗаказа = value;
                // *** Start programmer edit section *** (Заказ.СтатусЗаказа Set end)

                // *** End programmer edit section *** (Заказ.СтатусЗаказа Set end)
            }
        }
        
        /// <summary>
        /// Сумма.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Сумма CustomAttributes)

        // *** End programmer edit section *** (Заказ.Сумма CustomAttributes)
        public virtual decimal Сумма
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Сумма Get start)

                // *** End programmer edit section *** (Заказ.Сумма Get start)
                decimal result = this.fСумма;
                // *** Start programmer edit section *** (Заказ.Сумма Get end)

                // *** End programmer edit section *** (Заказ.Сумма Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Сумма Set start)

                // *** End programmer edit section *** (Заказ.Сумма Set start)
                this.fСумма = value;
                // *** Start programmer edit section *** (Заказ.Сумма Set end)

                // *** End programmer edit section *** (Заказ.Сумма Set end)
            }
        }
        
        /// <summary>
        /// Заказ.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Клиент CustomAttributes)

        // *** End programmer edit section *** (Заказ.Клиент CustomAttributes)
        [PropertyStorage(new string[] {
                "Клиент"})]
        public virtual IIS.АСУ_Ателье.Клиент Клиент
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Клиент Get start)

                // *** End programmer edit section *** (Заказ.Клиент Get start)
                IIS.АСУ_Ателье.Клиент result = this.fКлиент;
                // *** Start programmer edit section *** (Заказ.Клиент Get end)

                // *** End programmer edit section *** (Заказ.Клиент Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Клиент Set start)

                // *** End programmer edit section *** (Заказ.Клиент Set start)
                this.fКлиент = value;
                // *** Start programmer edit section *** (Заказ.Клиент Set end)

                // *** End programmer edit section *** (Заказ.Клиент Set end)
            }
        }
        
        /// <summary>
        /// Заказ.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Модель CustomAttributes)

        // *** End programmer edit section *** (Заказ.Модель CustomAttributes)
        [PropertyStorage(new string[] {
                "Модель"})]
        public virtual IIS.АСУ_Ателье.МодельОдежды Модель
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Модель Get start)

                // *** End programmer edit section *** (Заказ.Модель Get start)
                IIS.АСУ_Ателье.МодельОдежды result = this.fМодель;
                // *** Start programmer edit section *** (Заказ.Модель Get end)

                // *** End programmer edit section *** (Заказ.Модель Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Модель Set start)

                // *** End programmer edit section *** (Заказ.Модель Set start)
                this.fМодель = value;
                // *** Start programmer edit section *** (Заказ.Модель Set end)

                // *** End programmer edit section *** (Заказ.Модель Set end)
            }
        }
        
        /// <summary>
        /// Заказ.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Цех CustomAttributes)

        // *** End programmer edit section *** (Заказ.Цех CustomAttributes)
        [PropertyStorage(new string[] {
                "Цех"})]
        public virtual IIS.АСУ_Ателье.Цех Цех
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Цех Get start)

                // *** End programmer edit section *** (Заказ.Цех Get start)
                IIS.АСУ_Ателье.Цех result = this.fЦех;
                // *** Start programmer edit section *** (Заказ.Цех Get end)

                // *** End programmer edit section *** (Заказ.Цех Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Цех Set start)

                // *** End programmer edit section *** (Заказ.Цех Set start)
                this.fЦех = value;
                // *** Start programmer edit section *** (Заказ.Цех Set end)

                // *** End programmer edit section *** (Заказ.Цех Set end)
            }
        }
        
        /// <summary>
        /// Заказ.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Мастер CustomAttributes)

        // *** End programmer edit section *** (Заказ.Мастер CustomAttributes)
        [PropertyStorage(new string[] {
                "Мастер"})]
        public virtual IIS.АСУ_Ателье.Мастер Мастер
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Мастер Get start)

                // *** End programmer edit section *** (Заказ.Мастер Get start)
                IIS.АСУ_Ателье.Мастер result = this.fМастер;
                // *** Start programmer edit section *** (Заказ.Мастер Get end)

                // *** End programmer edit section *** (Заказ.Мастер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Мастер Set start)

                // *** End programmer edit section *** (Заказ.Мастер Set start)
                this.fМастер = value;
                // *** Start programmer edit section *** (Заказ.Мастер Set end)

                // *** End programmer edit section *** (Заказ.Мастер Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗаказE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаказE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаказE", typeof(IIS.АСУ_Ателье.Заказ));
                }
            }
            
            /// <summary>
            /// "ЗаказL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаказL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаказL", typeof(IIS.АСУ_Ателье.Заказ));
                }
            }
        }
    }
}
