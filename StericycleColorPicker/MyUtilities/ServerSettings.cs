using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilities
{
    public class ServerSettings
    {
        #region singleton
        private ServerSettings() { }
        private static readonly Lazy<ServerSettings> _instance = new Lazy<ServerSettings>(() => new ServerSettings());
        public static ServerSettings Instance { get { return _instance.Value; } }
        #endregion

        #region CcContactCreator server config settings
        /**
        * Toggle processing of this customization
        * @var bool
        */
        public bool ccContactCreatorEnabled { get; set; }
        /**
        * Toggle processing of email addresses in the 'To' mail header field
        * @var bool
        */
        public bool toEnabled { get; set; }

        /**
        * Toggle processing of email addresses in the 'Cc' mail header field
        * @var bool
        */
        public bool ccEnabled { get; set; }

        /**
        * Toggle whether contacts should be created, or only existing contacts
        * should be used
        * @var bool
        */
        public bool contactCreate { get; set; }
        /**
        * Toggle whether created contacts' 'login' field should be set to their
        * email address
        * @var bool
        */
        public bool setContactLogin { get; set; }

        /**
        * Toggle whether existing contacts should be associated to incident, or
        * only new ones should be used
        * @var bool 
        */
        public bool assocExistingContacts { get; set; }

        /**
        * Toggle whether secondary contacts should be removed, that aren't processed
        * explicitly by this customization
        * @var bool
        */
        public bool removeContacts { get; set; }

        /**
        * First name to default to on contact create, if it couldn't be parsed
        * from the email header
        * Defaults to EGW_DEFAULT_FIRST_NAME config verb value if
        * EU_CUST_NAMES_ENABLED is set
        * @var string
        */
        public string defaultFirstName { get; set; }
        /**
        * Last name to default to on contact create, if it couldn't be parsed
        * from the email header
        * Defaults to EGW_DEFAULT_LAST_NAME config verb value if
        * EU_CUST_NAMES_ENABLED is set
        * @var string
        */
        public string defaultLastName { get; set; }

        /**
        * List of email addresses to exclude from processing
        * @var array
        */
        public string excludeEmails { get; set; }

        /**
        * Regular Expression of Emails to Exclude
        * @var string
        */

        public string excludeEmailsRegex;

        /**
        * List of hostnames to exclude from contact association and creation
        * @var array
        */
        public string excludeHosts { get; set; }

        /*     * *************** */
        /* Debug Settings */
        /*     * *************** */

        /**
        * Toggle debugging state. If 'on' all object properties will be parsed, 
        * log file will be written, and PHP error reporting will be turned on for
        * E_WARNING and above.
        * @var bool
        */

        public bool debug { get; set; }

        /**
        * Detail text to add to top-level exceptions
        * @var string
        */
        public string cc_last_processed_thread { get; set; }
        /**
        * Detail text to add to top-level exceptions
        * @var string
        */
        #endregion

        #region  Contact Assing Orgs server config settings

        //unknown/unidentified Org
        public int defaultOrgID {get;set;}

        #endregion

        /// <summary>
        /// UserName for SOAP Service Authentication
        /// </summary>
        //public string RNSOAPUser { get; set; }

    }
}
