using covidvaccineAPI.CORE.DTO;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.INFRA.Service
{
    public class UserInfoService : IUserInfoService
    {

        private readonly IUserInfoRepository _userInfoRepository;



        public UserInfoService(IUserInfoRepository userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }


        public List<UserInfo> userInfos()
        {
            return _userInfoRepository.userInfos();
        }
    }
}
