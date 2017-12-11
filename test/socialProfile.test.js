var assert = require('assert'),
  _ = require('lodash'),
  hootsuite = require('./helper/connection');

describe('Social profile', function () {
  describe('#find', function () {
    it('Retrieves the social profiles that the authenticated user has access to.', function (done) {
      hootsuite.socialProfile.find().then(function (response) {
        console.log('1', response);
        // assert.equal(response.result.length, 1);
        // assert.equal(response.result[0].id, 1001);
        // assert(_.has(response.result[0], 'name'));
        // assert(_.has(response.result[0], 'workspaceName'));
        done();
      });
    });
  });
  describe('#findById', function () {
    it('Retrieve a social profile. Requires BASIC_USAGE permission on the social profile.', function (done) {
      hootsuite.socialProfile.findById('1234').then(function (response) {
        console.log('2', response);
        // assert.equal(response.result.length, 1);
        // assert.equal(response.result[0].id, 1001);
        // assert(_.has(response.result[0], 'name'));
        // assert(_.has(response.result[0], 'workspaceName'));
        done();
      });
    });
  });
  describe('#findByIdTeams', function () {
    it('Retrieves a list of team IDs with access to a social profile.', function (done) {
      hootsuite.socialProfile.findByIdTeams('1234').then(function (response) {
        console.log('3', response);
        // assert.equal(response.result.length, 1);
        // assert.equal(response.result[0].id, 1001);
        // assert(_.has(response.result[0], 'name'));
        // assert(_.has(response.result[0], 'workspaceName'));
        done();
      });
    });
  });
});
