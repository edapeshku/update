using System;

namespace eSupport.Application.Infrastructure
{
    public static class API
    {
        public static class Client
        {
            public static string GetClient(string baseUri, string clientId)
            {
                return $"{baseUri}/{clientId}";
            }

            public static string GetAllClients(string baseUri)
            {
                return baseUri;
            }

            public static string AddNewClient(string baseUri)
            {
                return $"{baseUri}/new";
            }

            public static string ModifyClient(string baseUri, string clientId)
            {
                return $"{baseUri}/{clientId}/edit";
            }
        }

        public static class Equipment
        {
            public static string GetAllBrands(string baseUri)
            {
                return $"{baseUri}equipmentBrands";
            }

            public static string GetAllTypes(string baseUri)
            {
                return $"{baseUri}equipmentTypes";
            }

            public static string GetAllEquipments(string baseUri, int page, int take, int? brand, int? type)
            {
                var filterQs = "";

                if (brand.HasValue || type.HasValue)
                {
                    var brandQs = (brand.HasValue) ? brand.Value.ToString() : "null";
                    var typeQs = (type.HasValue) ? type.Value.ToString() : "null";
                    filterQs = $"/type/{typeQs}/brand/{brandQs}";
                }

                return $"{baseUri}items{filterQs}?pageIndex={page}&pageSize={take}";
            }

            public static string NewEquipment(string baseUri)
            {
                return $"{baseUri}/new";
            }

            public static string ModifyEquipment(string baseUri, string equipmentId)
            {
                return $"{baseUri}/{equipmentId}/edit";
            }

            public static string GetEquipment(string baseUri, string equipmentId)
            {
                return $"{baseUri}/{equipmentId}";
            }
        }

        public static class Ticket
        {
            public static string GetAllTicket(string baseUri)
            {
                return baseUri;
            }

            public static string GetTicket(string baseUri, string ticketId)
            {
                return $"{baseUri}/{ticketId}";
            }

            public static string NewTicket(string baseUri)
            {
                return $"{baseUri}/new";
            }

            public static string ModifyTicket(string baseUri, string ticketId)
            {
                return $"{baseUri}/{ticketId}/edit";
            }
        }

        public static class User
        {
            public static string GetUsers(string baseUri)
            {
                return baseUri;
            }

            public static string GetUser(string baseUri, string userId)
            {
                return $"{baseUri}/{userId}";
            }

            public static string NewUser(string baseUri)
            {
                return $"{baseUri}/new";
            }

            public static string ModifyUser(string baseUri, string userId)
            {
                return $"{baseUri}/{userId}/edit";
            }
        }

        public static class Invoice
        {
            public static string NewInvoice(string baseUri)
            {
                return $"{baseUri}/new";
            }

            public static string ModifyInvoice(string baseUri, string invoiceId)
            {
                return $"{baseUri}/{invoiceId}/edit";
            }

            public static string GetAllInvoices(string baseUri)
            {
                return baseUri;
            }

            public static string GetInvoice(string baseUri, string invoiceId)
            {
                return $"{baseUri}/{invoiceId}";
            }

            public static string PrintInvoice(string baseUri, string invoiceId)
            {
                return $"{baseUri}/{invoiceId}/print";
            }
        }

        public static class Email
        {
            public static string NewEmail(string baseUri, string userId)
            {
                return $"{baseUri}/{userId}/new";
            }

            public static string ReplyEmail(string baseUri, string emailId, string userId)
            {
                return $"{baseUri}/{emailId}/{userId}/email";
            }

            public static string GetEmail(string baseUri, string emailId)
            {
                return $"{baseUri}/{emailId}/email";
            }

            public static string GetAllEmails(string baseUri, string userId)
            {
                return $"{baseUri}/{userId}/emails";
            }
        }

        public static class Solution
        {
            public static string NewSolution(string baseUri)
            {
                return $"{baseUri}/new";
            }

            public static string AddToSolution(string baseUri, string solutionId)
            {
                return $"{baseUri}/{solutionId}/add";
            }

            public static string ReopenSolution(string baseUri, string solutionId)
            {
                return $"{baseUri}/{solutionId}/status=reopen";
            }

            public static string AddWaitingStatus(string baseUri, string solutionId)
            {
                return $"{baseUri}/{solutionId}/status=waiting";
            }

            public static string CloseSolution(string baseUri, string solutionId)
            {
                return $"{baseUri}/{solutionId}/status=close";
            }
        }
    }
}