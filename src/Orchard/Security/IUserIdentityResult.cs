
using System.Collections.Generic;

namespace Orchard.Security {
    public class IUserIdentityResult {

        public IUserIdentityResult(IUser user) {
            _user = user;
            _succeded = true;
        }

        public IUserIdentityResult(IEnumerable<string> errors) {
            _errors = errors;
            _succeded = false;
        }

        public IUserIdentityResult(string[] errors) {
            _errors = errors;
            _succeded = false;
        }

        private IUser _user;
        IEnumerable<string> _errors;
        bool _succeded;

        IEnumerable<string> Errors { get { return _errors; } }
        bool Succeeded { get { return _succeded; } }
        IUser User { get { return _user; } }
    }
}