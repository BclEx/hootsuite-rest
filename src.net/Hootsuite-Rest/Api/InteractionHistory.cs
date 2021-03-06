﻿using System;
using System.Threading.Tasks;

namespace Hootsuite.Api
{
    /// <summary>
    /// Class InteractionHistory.
    /// </summary>
    public class InteractionHistory
    {
        readonly HootsuiteClient _hootsuite;
        readonly Connection _connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionHistory" /> class.
        /// </summary>
        /// <param name="hootsuite">The hootsuite.</param>
        /// <param name="connection">The connection.</param>
        public InteractionHistory(HootsuiteClient hootsuite, Connection connection)
        {
            _hootsuite = hootsuite;
            _connection = connection;
        }

        /// <summary>
        /// Finds all.
        /// </summary>
        /// <param name="socialNetworkType">Type of the social network.</param>
        /// <param name="socialNetworkId">The social network identifier.</param>
        /// <param name="targetSocialNetworkId">The target social network identifier.</param>
        /// <param name="cursor">The cursor.</param>
        /// <param name="limit">The limit.</param>
        /// <param name="options">The options.</param>
        /// <returns>Task&lt;dynamic&gt;.</returns>
        /// <exception cref="ArgumentNullException">socialNetworkType
        /// or
        /// socialNetworkId
        /// or
        /// targetSocialNetworkId</exception>
        public Task<dynamic> FindAll(string socialNetworkType, string socialNetworkId, string targetSocialNetworkId, string cursor = null, int? limit = null, dynamic options = null)
        {
            if (socialNetworkType == null)
                throw new ArgumentNullException(nameof(socialNetworkType));
            if (socialNetworkId == null)
                throw new ArgumentNullException(nameof(socialNetworkId));
            if (targetSocialNetworkId == null)
                throw new ArgumentNullException(nameof(targetSocialNetworkId));
            var path = util.createPath("interactions", socialNetworkType);
            options = dyn.exp(options);
            options.query = new
            {
                socialNetworkId,
                targetSocialNetworkId,
                cursor,
                limit,
            };
            return _connection.get(path, options);
        }
    }
}
