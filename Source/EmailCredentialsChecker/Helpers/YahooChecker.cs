﻿namespace EmailCredentialsChecker.Helpers
{
    using System;

    using Models;

    using Pop3;

    public static class YahooChecker
    {
        public static bool? Check(Credential credential)
        {
            var client = new Pop3Client();
            try
            {
                client.Connect("pop.mail.yahoo.com", credential.Email, credential.Password, true);
                client.Disconnect();
                client.Dispose();
                return true;
            }
            catch (InvalidOperationException ex)
            {
                return false;
            }
            catch
            {
                return null;
            }
        }
    }
}
