﻿using System;
using System.Threading.Tasks;

namespace Hootsuite.Api
{
    /// <summary>
    /// Class SocialProfiles.
    /// </summary>
    public class SocialProfiles
    {
        readonly HootsuiteClient _hootsuite;
        readonly Connection _connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialProfiles" /> class.
        /// </summary>
        /// <param name="hootsuite">The hootsuite.</param>
        /// <param name="connection">The connection.</param>
        public SocialProfiles(HootsuiteClient hootsuite, Connection connection)
        {
            _hootsuite = hootsuite;
            _connection = connection;
        }

        /// <summary>
        /// Finds this instance.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <returns>Task&lt;JObject&gt;.</returns>
        public Task<dynamic> Find(dynamic options = null)
        {
            var path = util.createPath("socialProfiles");
            return _connection.get(path, options);
        }

        /// <summary>
        /// Finds the by identifier.
        /// </summary>
        /// <param name="socialProfileId">The social profile identifier.</param>
        /// <param name="options">The options.</param>
        /// <returns>Task&lt;JObject&gt;.</returns>
        /// <exception cref="ArgumentNullException">socialProfileId</exception>
        public Task<dynamic> FindById(string socialProfileId, dynamic options = null)
        {
            if (socialProfileId == null)
                throw new ArgumentNullException(nameof(socialProfileId));
            var path = util.createPath("socialProfiles", socialProfileId);
            return _connection.get(path, options);
        }

        /// <summary>
        /// Finds the by identifier teams.
        /// </summary>
        /// <param name="socialProfileId">The social profile identifier.</param>
        /// <param name="options">The options.</param>
        /// <returns>Task&lt;JObject&gt;.</returns>
        /// <exception cref="ArgumentNullException">socialProfileId</exception>
        public Task<dynamic> FindByIdTeams(string socialProfileId, dynamic options = null)
        {
            if (socialProfileId == null)
                throw new ArgumentNullException(nameof(socialProfileId));
            var path = util.createPath("socialProfiles", socialProfileId, "teams");
            return _connection.get(path, options);
        }
    }
}
