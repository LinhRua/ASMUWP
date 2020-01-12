using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1809E_UWP_CXL_ASM.Models;

namespace T1809E_UWP_CXL_ASM.Services

    {
    interface IMemberService
    {
        Task<String> Login(string email, string password);
        Task<string> Register(Member member);
        Task<String> GetMemberInformation(String token);
    }
    }
