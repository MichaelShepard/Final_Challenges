﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsRepository
{
    public class ClaimsRepo
    {
        private Queue<Claims> _listOfClaims = new Queue<Claims>();


        // Create
        public void CreateClaim(Claims newClaim)
        {
            _listOfClaims.Enqueue(newClaim);
        }

        //Review
        public Queue<Claims> GetClaims()    // access the list of all Claims
        {
            return _listOfClaims;
        }

        public Claims GetClaimByClaimId(string number) // access the properties in Claims and uses the ID to get the Claim by ID
        {
            foreach (Claims id in _listOfClaims)
            {
                if (id.ClaimID == number)
                {
                    return id;
                }
            }

            return null;
        }


        // Update 



        // Delete


       


    } // End of ClaimsRepo Class
} // End of Namespace
