var assert = require('assert'),
  _ = require('lodash'),
  hootsuite = require('./helper/connection');

describe('Teams', function () {
  describe('#createTeam', function () {
    it('Creates a team in an organization', function (done) {
      hootsuite.teams.createTeam('814984', 'name').then(function (response) {
        console.log(response);
        // assert.equal(response.data.length, 1);
        // assert.equal(response.data[0].id, 1001);
        // assert(_.has(response.data[0], 'name'));
        // assert(_.has(response.data[0], 'workspaceName'));
        done();
      }).catch(done);
    });
  });
  describe('#appendMemberById', function () {
    it('Adds a member to a team', function (done) {
      hootsuite.teams.appendMemberById('814984', '1234', '16494879').then(function (response) {
        console.log(response);
        // assert.equal(response.data.length, 1);
        // assert.equal(response.data[0].id, 1001);
        // assert(_.has(response.data[0], 'name'));
        // assert(_.has(response.data[0], 'workspaceName'));
        done();
      }).catch(done);
    });
  });
  describe('#findByIdMembers', function () {
    it('Retrieves the members in a team', function (done) {
      hootsuite.teams.findByIdMembers('814984', '1234').then(function (response) {
        console.log('2', response);
        console.log(response);
        // assert.equal(response.data.length, 1);
        // assert.equal(response.data[0].id, 1001);
        // assert(_.has(response.data[0], 'name'));
        // assert(_.has(response.data[0], 'workspaceName'));
        done();
      }).catch(done);
    });
  });
  describe('#findMemberByIdPermissions', function () {
    it('Retrieves team member’s team permissions', function (done) {
      hootsuite.teams.findMemberByIdPermissions('814984', '1234', '16494879').then(function (response) {
        console.log(response);
        // assert.equal(response.data.length, 1);
        // assert.equal(response.data[0].id, 1001);
        // assert(_.has(response.data[0], 'name'));
        // assert(_.has(response.data[0], 'workspaceName'));
        done();
      }).catch(done);
    });
  });
  describe('#findByIdSocialProfiles', function () {
    it('Retrieves the organization’s social profiles that an organization team can access', function (done) {
      hootsuite.teams.findByIdSocialProfiles('814984', '1234').then(function (response) {
        console.log(response);
        // assert.equal(response.data.length, 1);
        // assert.equal(response.data[0].id, 1001);
        // assert(_.has(response.data[0], 'name'));
        // assert(_.has(response.data[0], 'workspaceName'));
        done();
      }).catch(done);
    });
  });
});
