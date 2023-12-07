﻿using FogabaMailService.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Linq;
using System.Text.Json;

namespace Servicios_CRM_Replica.Services
{
    public class OpportunityBaseServices
    {
        private ProvMicroOpContext _dbProvMicroOpContext;
        //private OpportunityBase _oppBase;
        //private Contacto _contact;
        //private SystemUserBase _user;

        //Logica de negocio
        //Reglas de negocio
        //Se inyecta en el controlador
        //Que datos de la oportunidad/contacto/usuario deberia exponer?

        public OpportunityBaseServices(ProvMicroOpContext dbProvMicroOpContext)
        {
            this._dbProvMicroOpContext = dbProvMicroOpContext;
        }

        public object getOpportunities()
        {
            try
            {
                //filtrar las solicitudes fogaba que pasaron a documentacion en las ultimas 24hs
                //DateTime last24h = DateTime.Now.AddDays(-1); //ultimas 24hs
                DateTime last24h = DateTime.Now.AddHours(-24);

                /*
                var fogaba = _dbProvMicroOpContext.OpportunityBases
                    .Where(o => o.PnetCreditocongarantiafogaba == true
                    && o.StatusCode == 102610002
                    && o.ModifiedOn >= last24h)
                    .Join(
                        _dbProvMicroOpContext.ContactBases,
                        opp => opp.CustomerId,
                        contact => contact.ContactId,
                        (opp, contact) => new
                        {
                            contactName = contact.FullName,
                            contactCuit2 = contact.PnetTaxDocumentNumber2,
                            contactCuit = contact.PnetTaxDocumentNumber,
                            contactCuit3 = contact.PnetTaxDocumentNumber3,
                            oppNumber = opp.Name,
                            oppAmount = opp.PnetCreditAmount,
                            oppQuotas = opp.PnetQuotasNumber,
                            oppAmortSystem = opp.PnetAmortizationsystem,
                            //convenio
                        }
                    )
                    .Join(
                        _dbProvMicroOpContext.PnetSitevisitBases,
                        oppVT => oppVT.PnetSiteVisitNumber,
                        siteVisit => siteVisit.PnetSitevisitId,
                        (opp, sitevisit) => new
                        {
                            sitevisit = sitevisit.PnetName
                        }
                    )
                    .ToList();*/

                var fogaba = (from opp in _dbProvMicroOpContext.OpportunityBases
                              where opp.StatusCode == 102610002 && opp.PnetCreditocongarantiafogaba == true
                              && opp.ModifiedOn >= last24h
                              join contact in _dbProvMicroOpContext.ContactBases on opp.CustomerId equals contact.ContactId
                              join user in _dbProvMicroOpContext.SystemUserBases on opp.OwnerId equals user.SystemUserId
                              join subsidiary in _dbProvMicroOpContext.TeamBases on user.PnetSubsidiary equals subsidiary.TeamId

                              join vt in _dbProvMicroOpContext.PnetSitevisitBases on opp.PnetSiteVisitNumber equals vt.PnetSitevisitId
                              join vtConvenio in _dbProvMicroOpContext.PnetConveniosdecreditos on vt.PnetConvenio equals vtConvenio.PnetConveniosdecreditosId

                              //join campaign in _dbProvMicroOpContext.CampaignResponseBases on opp.CampaignId equals campaign.PnetConvenio
                              //join campaignConvenio in _dbProvMicroOpContext.PnetConveniosdecreditos on campaign.PnetConvenio equals campaignConvenio.PnetConveniosdecreditosId
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
                                  oppAmortization = opp.PnetAmortizationsystem,
                                  //vtConvenioId = vt.PnetConvenio,
                                  vtConvenioName = vtConvenio.PnetName,
                                  //campaignConvenio = campaign.PnetConvenio,
                                  //campConvenioName = campaignConvenio.PnetName,
                                  oppOwner = user.FullName,
                                  //oppOwnerMail = user.InternalEmailAddress,
                                  //contactSubsidiary = contact.PnetSubsidaryNumber,
                                  subsidiaryName = subsidiary.Name
                              })
                               .ToList();

                return fogaba;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
