using FogabaMailService.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Linq;
using System.Text.Json;

namespace Servicios_CRM_Replica.Services
{
    public class OpportunityBaseServices
    {
        private ProvMicroOpContext _dbProvMicroOpContext;

        public OpportunityBaseServices(ProvMicroOpContext dbProvMicroOpContext)
        {
            this._dbProvMicroOpContext = dbProvMicroOpContext;
        }

        public object getFogabaOpportunities()
        {
            try
            {
                DateTime last24h = DateTime.Now.AddHours(-24);

                var vtQuery = (from opp in _dbProvMicroOpContext.OpportunityBases
                               where opp.StatusCode == 102610002 &&
                               opp.PnetCreditocongarantiafogaba == true
                               && opp.ModifiedOn >= last24h

                               join contact in _dbProvMicroOpContext.ContactBases on opp.CustomerId equals contact.ContactId
                               join user in _dbProvMicroOpContext.SystemUserBases on opp.OwnerId equals user.SystemUserId
                               join subsidiary in _dbProvMicroOpContext.TeamBases on user.PnetSubsidiary equals subsidiary.TeamId
                               join zonalchief in _dbProvMicroOpContext.SystemUserBases on user.ParentSystemUserId equals zonalchief.SystemUserId

                               join vt in _dbProvMicroOpContext.PnetSitevisitBases on opp.PnetSiteVisitNumber equals vt.PnetSitevisitId
                               join vtConvenio in _dbProvMicroOpContext.PnetConveniosdecreditos on vt.PnetConvenio equals vtConvenio.PnetConveniosdecreditosId
                               select new
                               {
                                   contactName = contact.FullName,
                                   contactCuil2 = contact.PnetTaxDocumentNumber2,
                                   contactCuil = contact.PnetTaxDocumentNumber,
                                   contactCuil3 = contact.PnetTaxDocumentNumber3,
                                   oppNumber = opp.Name,
                                   oppAmount = opp.PnetCreditAmount,
                                   oppQuotas = opp.PnetQuotasNumber,
                                   oppIRate = opp.PnetInterestRateAnual,
                                   oppAmortization = getAmortizationName(opp.PnetAmortizationsystem),
                                   convenioName = vtConvenio.PnetName,
                                   oppOwner = user.FullName,
                                   oppOwnerMail = user.InternalEmailAddress,
                                   subsidiaryName = subsidiary.Name,
                                   zonalChief = zonalchief.FullName
                               }).ToList();

                var campaignQuery = (from opp in _dbProvMicroOpContext.OpportunityBases
                                     where opp.StatusCode == 102610002 &&
                                     opp.PnetCreditocongarantiafogaba == true
                                     && opp.ModifiedOn >= last24h

                                     join contact in _dbProvMicroOpContext.ContactBases on opp.CustomerId equals contact.ContactId
                                     join user in _dbProvMicroOpContext.SystemUserBases on opp.OwnerId equals user.SystemUserId
                                     join subsidiary in _dbProvMicroOpContext.TeamBases on user.PnetSubsidiary equals subsidiary.TeamId
                                     join zonalchief in _dbProvMicroOpContext.SystemUserBases on user.ParentSystemUserId equals zonalchief.SystemUserId

                                     join campaign in _dbProvMicroOpContext.CampaignResponseBases on opp.PnetCampaignResponseId equals campaign.ActivityId
                                     join campaignConvenio in _dbProvMicroOpContext.PnetConveniosdecreditos on campaign.PnetConvenio equals campaignConvenio.PnetConveniosdecreditosId
                                     select new
                                     {
                                         contactName = contact.FullName,
                                         contactCuil2 = contact.PnetTaxDocumentNumber2,
                                         contactCuil = contact.PnetTaxDocumentNumber,
                                         contactCuil3 = contact.PnetTaxDocumentNumber3,
                                         oppNumber = opp.Name,
                                         oppAmount = opp.PnetCreditAmount,
                                         oppQuotas = opp.PnetQuotasNumber,
                                         oppIRate = opp.PnetInterestRateAnual,
                                         oppAmortization = getAmortizationName(opp.PnetAmortizationsystem),
                                         convenioName = campaignConvenio.PnetName,
                                         oppOwner = user.FullName,
                                         oppOwnerMail = user.InternalEmailAddress,
                                         subsidiaryName = subsidiary.Name,
                                         zonalChief = zonalchief.FullName
                                     }).ToList();

                var fogabaQueries = vtQuery.Cast<object>().Concat(campaignQuery);

                return fogabaQueries;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static string getAmortizationName(int? value)
        {
            if (value == null)
            {
                throw new Exception("Empty value");
            } else if (value == 102610000)
            {
                return "Francés";
            } else
            {
                return "Alemán";
            }
        }

        public object getOpportunities()
        {
            try
            {

                var query = (from opp in _dbProvMicroOpContext.OpportunityBases
                             where )

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean validateTraspasoDeCarteraData(string data)
        {
            try 
            {

                var query 

            } catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
