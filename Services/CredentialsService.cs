using System.Windows;
using TicketToolv2.Core.Contracts.Services;
using TicketToolv2.Models;
using TicketToolv2.Core.Models;
namespace TicketToolv2.Services;

public class CredentialService : ICredentialsService
{

    public CredentialService()
    {
    }

    public void InitializeCred()
    {


        var database = GetDatabaseCred();
        var zendesk = GetZendeskCred();
        SetCred(zendesk, database);
    }

    public void SetCred(ZendeskAuth zendeskAuth, DatabaseAuth databaseAuth)
    {
        //TODO add
        throw new NotImplementedException();
    }

    public ZendeskAuth GetZendeskCred()
    {
        throw new NotImplementedException();
    }
    
    
    
    public DatabaseAuth GetDatabaseCred()
    {
        throw new NotImplementedException();
    }

    public string GetServer()
    {
        if (App.Current.Properties.Contains("Server"))
        {
            var ServerName = App.Current.Properties["Server"].ToString();
            return ServerName;
        }
        else
        {
            throw new Exception("Server name not found");
        }
        
    }

    public string GetDataBase()
    {
        if (App.Current.Properties.Contains("Database"))
        {
            var DatabaseName = App.Current.Properties["Database"].ToString();
            return DatabaseName;
        }
        else
        {
            throw new Exception("Database name not found");
        }
    }
    
    public string GetUsername()
    {
        if (App.Current.Properties.Contains("Username"))
        {
            var Username = App.Current.Properties["Username"].ToString();
            return Username;
        }
        else
        {
            throw new Exception("Username not found");
        }
    }
    
    public string GetPassword()
    {
        if (App.Current.Properties.Contains("Password"))
        {
            var Password = App.Current.Properties["Password"].ToString();
            return Password;
        }
        else
        {
            throw new Exception("Password not found");
        }
    }
    
    public string GetZendeskUrl()
    {
        if (App.Current.Properties.Contains("ZendeskUrl"))
        {
            var ZendeskUrl = App.Current.Properties["ZendeskUrl"].ToString();
            return ZendeskUrl;
        }
        else
        {
            throw new Exception("ZendeskUrl not found");
        }
    }
    
    public string GetZendeskEmail()
    {
        if (App.Current.Properties.Contains("ZendeskEmail"))
        {
            var ZendeskEmail = App.Current.Properties["ZendeskEmail"].ToString();
            return ZendeskEmail;
        }
        else
        {
            throw new Exception("ZendeskEmail not found");
        }
    }
    
    public string GetZendeskToken()
    {
        if (App.Current.Properties.Contains("ZendeskToken"))
        {
            var ZendeskToken = App.Current.Properties["ZendeskToken"].ToString();
            return ZendeskToken;
        }
        else
        {
            throw new Exception("ZendeskToken not found");
        }
    }
}