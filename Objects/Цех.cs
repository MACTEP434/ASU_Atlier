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
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Цех.
    /// </summary>
    // *** Start programmer edit section *** (Цех CustomAttributes)

    // *** End programmer edit section *** (Цех CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЦехE", new string[] {
            "КодЦеха as \'Код цеха\'",
            "НаименованиеЦеха as \'Наименование цеха\'"})]
    [View("ЦехL", new string[] {
            "КодЦеха as \'Код цеха\'",
            "НаименованиеЦеха as \'Наименование цеха\'"})]
    public class Цех : ICSSoft.STORMNET.DataObject
    {
        
        private int fКодЦеха;
        
        private string fНаименованиеЦеха;
        
        // *** Start programmer edit section *** (Цех CustomMembers)

        // *** End programmer edit section *** (Цех CustomMembers)

        
        /// <summary>
        /// КодЦеха.
        /// </summary>
        // *** Start programmer edit section *** (Цех.КодЦеха CustomAttributes)

        // *** End programmer edit section *** (Цех.КодЦеха CustomAttributes)
        [DisableInsertProperty(true)]
        [NotNull()]
        public virtual int КодЦеха
        {
            get
            {
                // *** Start programmer edit section *** (Цех.КодЦеха Get start)

                // *** End programmer edit section *** (Цех.КодЦеха Get start)
                int result = this.fКодЦеха;
                // *** Start programmer edit section *** (Цех.КодЦеха Get end)

                // *** End programmer edit section *** (Цех.КодЦеха Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Цех.КодЦеха Set start)

                // *** End programmer edit section *** (Цех.КодЦеха Set start)
                this.fКодЦеха = value;
                // *** Start programmer edit section *** (Цех.КодЦеха Set end)

                // *** End programmer edit section *** (Цех.КодЦеха Set end)
            }
        }
        
        /// <summary>
        /// НаименованиеЦеха.
        /// </summary>
        // *** Start programmer edit section *** (Цех.НаименованиеЦеха CustomAttributes)

        // *** End programmer edit section *** (Цех.НаименованиеЦеха CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string НаименованиеЦеха
        {
            get
            {
                // *** Start programmer edit section *** (Цех.НаименованиеЦеха Get start)

                // *** End programmer edit section *** (Цех.НаименованиеЦеха Get start)
                string result = this.fНаименованиеЦеха;
                // *** Start programmer edit section *** (Цех.НаименованиеЦеха Get end)

                // *** End programmer edit section *** (Цех.НаименованиеЦеха Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Цех.НаименованиеЦеха Set start)

                // *** End programmer edit section *** (Цех.НаименованиеЦеха Set start)
                this.fНаименованиеЦеха = value;
                // *** Start programmer edit section *** (Цех.НаименованиеЦеха Set end)

                // *** End programmer edit section *** (Цех.НаименованиеЦеха Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЦехE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЦехE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЦехE", typeof(IIS.АСУ_Ателье.Цех));
                }
            }
            
            /// <summary>
            /// "ЦехL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЦехL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЦехL", typeof(IIS.АСУ_Ателье.Цех));
                }
            }
        }
    }
}
