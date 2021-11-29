/*
*	<copyright file="Aula17_SRP.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/28/2021 5:23:44 PM</date>
*	<description></description>
*	
*	See
*	https://www.c-sharpcorner.com/article/solid-single-responsibility-principle-with-c-sharp/
**/
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MailKit.Net.Smtp;         //pm> Install-Package MailKit
using MailKit.Security;
using MimeKit;
//See https://dotnetcoretutorials.com/2017/11/02/using-mailkit-send-receive-email-asp-net-core/


namespace SRP
{
    #region BeforeChanges

    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/28/2021 5:23:44 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class EmployeeService
    {
        #region EmployeeData

        public string FirstName { get; set; }
        public string LastName { get; set; }

        #endregion

        #region EmployeeMethods
        public bool EmployeeRegistration(EmployeeService employee)
        {
            if (!EmployeesData.Employees.Contains(employee))
            {
                EmployeesData.Employees.Add(employee);
                return true;
            }
            return false;
        }

        #endregion

    }
    public class EmployeesData
    {
        public static List<EmployeeService> Employees { get; set; } = new List<EmployeeService>();

    }

    #endregion

    #region AfterChanges_I

    public class EmployeeServiceII
    {
        public async Task EmployeeRegistration(Employee employee)
        {
            EmployeesDataII.Employees.Add(employee);
            await SendEmailAsync(employee.Email, "Registration", "Congratulation ! Your are successfully registered.");
        }
        public async Task SendEmailAsync(string email, string subject, string message) //novo
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Mark Adam", "madam@sample.com"));
            emailMessage.To.Add(new MailboxAddress(string.Empty, email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("plain") { Text = message };

            using (SmtpClient smtpClient = new SmtpClient())
            {
                smtpClient.LocalDomain = "sample.com";
                await smtpClient.ConnectAsync("smtp.relay.uri", 25, SecureSocketOptions.None).ConfigureAwait(false);
                await smtpClient.SendAsync(emailMessage).ConfigureAwait(false);
                await smtpClient.DisconnectAsync(true).ConfigureAwait(false);
            }
        }
 
    }

    public class EmployeesDataII
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>();
    }
  
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }       //novo
    }
    #endregion

    #region AfterChanges_II
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Mark Adam", "madam@sample.com"));
            emailMessage.To.Add(new MailboxAddress(string.Empty, email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("plain") { Text = message };

            using (SmtpClient smtpClient = new SmtpClient())
            {
                smtpClient.LocalDomain = "paathshaala.com";
                await smtpClient.ConnectAsync("smtp.relay.uri", 25, SecureSocketOptions.None).ConfigureAwait(false);
                await smtpClient.SendAsync(emailMessage).ConfigureAwait(false);
                await smtpClient.DisconnectAsync(true).ConfigureAwait(false);
            }
        }
    }

    public class EmployeeServiceIII
    {
        public async Task EmployeeRegistration(Employee employee)
        {
            EmployeesDataII.Employees.Add(employee);
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync(employee.Email, "Registration", "Congratulation ! Your are successfully registered.");
        }
    }

    #endregion
}
