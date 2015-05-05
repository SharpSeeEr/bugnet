using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugNET.Models;
using BugNET.Common;

namespace BugNET.DAL
{
    public interface IDataProvider
    {
        bool SupportsProjectCloning { get; }

        //*** ABSTRACT METHODS ***/
        DataAccessException ProcessException(Exception ex);

        // Category
        int CreateNewCategory(Category newCategory);
        bool DeleteCategory(int categoryId);
        bool UpdateCategory(Category categoryToUpdate);
        List<Category> GetCategoriesByProjectId(int projectId);
        List<Category> GetRootCategoriesByProjectId(int projectId);
        List<Category> GetChildCategoriesByCategoryId(int categoryId);
        Category GetCategoryById(int categoryId);

        // Issue
        bool DeleteIssue(int issueId);
        List<Issue> GetIssuesByProjectId(int projectId);
        Issue GetIssueById(int issueId);
        bool UpdateIssue(Issue issueToUpdate);
        int CreateNewIssue(Issue issueToCreate);
        List<Issue> GetIssuesByRelevancy(int projectId, string username);
        List<Issue> GetIssuesByAssignedUserName(int projectId, string assignedUserName);
        List<Issue> GetIssuesByCreatorUserName(int projectId, string creatorUserName);
        List<Issue> GetIssuesByOwnerUserName(int projectId, string creatorUserName);
        List<Issue> GetOpenIssues(int projectId);
        List<Issue> GetMonitoredIssuesByUserName(object userId, ICollection<KeyValuePair<string, string>> sortFields, List<int> projects, bool excludeClosedStatus);
        List<Issue> GetMonitoredIssuesByUserName(string userName, bool excludeClosedStatus);
        bool UpdateIssueLastUpdated(int issueId, string lastUpdatedUsername);
        //List<IssueCount> GetIssueStatusCountByProject(int projectId);
        //List<IssueCount> GetIssueMilestoneCountByProject(int projectId);
        //List<IssueCount> GetIssueUserCountByProject(int projectId);
        //List<IssueCount> GetIssueTypeCountByProject(int projectId);
        //List<IssueCount> GetIssuePriorityCountByProject(int projectId);
        int GetIssueUnassignedCountByProject(int projectId);
        int GetIssueCountByProjectAndCategory(int projectId, int categoryId);
        int GetIssueUnscheduledMilestoneCountByProject(int projectId);
        string GetSelectedIssueColumnsByUserName(string userName, int projectId);
        void SetSelectedIssueColumnsByUserName(string userName, int projectId, string columns);

        // Default values
        List<DefaultValue> GetDefaultIssueTypeByProjectId(int projectId);
        bool SetDefaultIssueTypeByProjectId(DefaultValue defaultVal);


        // Related Issues
        List<RelatedIssue> GetChildIssues(int issueId);
        List<RelatedIssue> GetParentIssues(int issueId);
        List<RelatedIssue> GetRelatedIssues(int issueId);
        int CreateNewChildIssue(int primaryIssueId, int secondaryIssueId);
        bool DeleteChildIssue(int primaryIssueId, int secondaryIssueId);
        int CreateNewParentIssue(int primaryIssueId, int secondaryIssueId);
        bool DeleteParentIssue(int primaryIssueId, int secondaryIssueId);
        int CreateNewRelatedIssue(int primaryIssueId, int secondaryIssueId);
        bool DeleteRelatedIssue(int primaryIssueId, int secondaryIssueId);

        // Queries
        List<Query> GetQueriesByUserName(string username, int projectId);
        bool SaveQuery(string username, int projectId, string queryName, bool isPublic, List<QueryClause> queryClauses);
        bool UpdateQuery(int queryId, string username, int projectId, string queryName, bool isPublic, List<QueryClause> queryClauses);
        bool DeleteQuery(int queryId);
        List<RequiredField> GetRequiredFieldsForIssues();
        void PerformIssueCommentSearchQuery(ref List<IssueComment> list, List<QueryClause> queryClauses);

        List<Issue> PerformQuery(List<QueryClause> queryClauses, ICollection<KeyValuePair<string, string>> sortFields, int projectId = 0);

        List<Issue> PerformSavedQuery(int projectId, int queryId, ICollection<KeyValuePair<string, string>> sortFields);
        List<QueryClause> GetQueryClausesByQueryId(int queryId);
        Query GetQueryById(int queryId);

        // IssueComments
        int CreateNewIssueComment(IssueComment newComment);
        List<IssueComment> GetIssueCommentsByIssueId(int issueId);
        bool DeleteIssueCommentById(int commentId);
        bool UpdateIssueComment(IssueComment issueCommentToUpdate);
        IssueComment GetIssueCommentById(int issueCommentId);

        // IssueAttachments
        int CreateNewIssueAttachment(IssueAttachment newAttachment);
        List<IssueAttachment> GetIssueAttachmentsByIssueId(int issueId);
        IssueAttachment GetIssueAttachmentById(int attachmentId);
        bool DeleteIssueAttachment(int attachmentId);
        IssueAttachment GetAttachmentForDownload(int attachmentId, string requestingUser = "");

        // IssueHistory
        List<IssueHistory> GetIssueHistoryByIssueId(int issueId);
        int CreateNewIssueHistory(IssueHistory newHistory);

        // IssueNotifications
        int CreateNewIssueNotification(IssueNotification newNotification);
        List<IssueNotification> GetIssueNotificationsByIssueId(int issueId);
        bool DeleteIssueNotification(int issueId, string username);

        //IssueRevisions
        int CreateNewIssueRevision(IssueRevision newIssueRevision);
        List<IssueRevision> GetIssueRevisionsByIssueId(int issueId);
        bool DeleteIssueRevision(int issueRevisionId);

        //IssueVote
        int CreateNewIssueVote(IssueVote newIssueVote);
        bool HasUserVoted(int issueId, string username);

        // Project
        int CreateNewProject(Project newProject);
        bool DeleteProject(int projectId);
        List<Project> GetAllProjects(bool? activeOnly = true);
        Project GetProjectById(int projectId);
        List<Project> GetProjectsByMemberUserName(string username);
        List<Project> GetProjectsByMemberUserName(string userName, bool activeOnly);
        bool UpdateProject(Project projectToUpdate);
        bool AddUserToProject(string userName, int projectId);
        bool RemoveUserFromProject(string userName, int projectId);
        int CloneProject(int projectId, string projectName, string creatorUserName = "");
        Project GetProjectByCode(string projectCode);
        List<Project> GetPublicProjects();
        bool IsUserProjectMember(string userName, int projectId);
        int[] GetProjectRoadmapProgress(int projectId, int milestoneId);
        bool DeleteProjectImage(int projectId);

        // Milestone
        int CreateNewMilestone(Milestone newMileStone);
        bool DeleteMilestone(int milestoneId);
        List<Milestone> GetMilestonesByProjectId(int projectId, bool notCompleted);
        List<Milestone> GetMilestonesByProjectId(int projectId);
        Milestone GetMilestoneById(int milestoneId);
        bool UpdateMilestone(Milestone milestoneToUpdate);
        bool CanDeleteMilestone(int milestoneId);

        // Project Mailbox
        ProjectMailbox GetProjectByMailbox(string mailbox);
        ProjectMailbox GetProjectMailboxByMailboxId(int projectMailboxId);
        List<ProjectMailbox> GetMailboxsByProjectId(int projectId);
        int CreateProjectMailbox(ProjectMailbox mailboxToUpdate);
        bool DeleteProjectMailbox(int mailboxId);
        bool UpdateProjectMailbox(ProjectMailbox mailboxToUpdate);

        // Status
        int CreateNewStatus(Status newStatus);
        bool UpdateStatus(Status statusToUpdate);
        bool DeleteStatus(int statusId);
        List<Status> GetStatusByProjectId(int projectId);
        Status GetStatusById(int statusId);
        bool CanDeleteStatus(int statusId);

        // Priority
        int CreateNewPriority(Priority newPriority);
        bool DeletePriority(int priorityId);
        List<Priority> GetPrioritiesByProjectId(int projectId);
        Priority GetPriorityById(int priorityId);
        bool UpdatePriority(Priority priorityToUpdate);
        bool CanDeletePriority(int priorityId);

        // Issue Type
        IssueType GetIssueTypeById(int issueTypeId);
        int CreateNewIssueType(IssueType issueTypeToCreate);
        bool DeleteIssueType(int issueTypeId);
        bool UpdateIssueType(IssueType issueTypeToUpdate);
        List<IssueType> GetIssueTypesByProjectId(int projectId);
        bool CanDeleteIssueType(int issueTypeId);

        // Resolution
        int CreateNewResolution(Resolution resolutionToCreate);
        bool DeleteResolution(int resolutionId);
        bool UpdateResolution(Resolution resolutionToUpdate);
        Resolution GetResolutionById(int resolutionId);
        List<Resolution> GetResolutionsByProjectId(int projectId);
        bool CanDeleteResolution(int ResolutionId);

        //Project Notifications
        int CreateNewProjectNotification(ProjectNotification newProjectNotification);
        List<ProjectNotification> GetProjectNotificationsByProjectId(int projectId);
        bool DeleteProjectNotification(int projectId, string username);
        List<ProjectNotification> GetProjectNotificationsByUsername(string username);

        //Users
        //List<ITUser> GetUsersByProjectId(int projectId);
        //List<ITUser> GetUsersByProjectId(int projectId, bool excludeReadOnlyUsers);
        string GetUserNameByPasswordResetToken(string token);

        // Role
        List<Role> GetAllRoles();
        bool UpdateRole(Role roleToUpdate);
        int CreateNewRole(Role newRole);
        bool RoleExists(string roleName, int projectId);
        List<Role> GetRolesByUserName(string userName, int projectId);
        bool RemoveUserFromRole(string userName, int roleId);
        bool AddUserToRole(string userName, int roleId);
        bool DeleteRole(int roleId);
        Role GetRoleById(int roleId);
        List<Role> GetRolesByUserName(string userName);
        List<Role> GetRolesByProject(int projectId);

        // Role Permissions
        List<Permission> GetAllPermissions();
        List<RolePermission> GetRolePermissions();
        List<Permission> GetPermissionsByRoleId(int roleId);
        bool DeletePermission(int roleId, int permissionId);
        bool AddPermission(int roleId, int permissionId);

        // Custom Fields
        List<CustomField> GetCustomFieldsByProjectId(int projectId);
        CustomField GetCustomFieldById(int customFieldId);
        List<CustomField> GetCustomFieldsByIssueId(int issueId);
        int CreateNewCustomField(CustomField newCustomField);
        bool UpdateCustomField(CustomField customFieldToUpdate);
        bool DeleteCustomField(int customFieldId);
        bool SaveCustomFieldValues(int issueId, List<CustomField> fields);

        // Custom Field Selections
        int CreateNewCustomFieldSelection(CustomFieldSelection newCustomFieldSelection);
        bool DeleteCustomFieldSelection(int customFieldSelectionId);
        List<CustomFieldSelection> GetCustomFieldSelectionsByCustomFieldId(int customFieldId);
        CustomFieldSelection GetCustomFieldSelectionById(int customFieldSelectionId);
        bool UpdateCustomFieldSelection(CustomFieldSelection customFieldSelectionToUpdate);

        // Host Settings
        List<HostSetting> GetHostSettings();
        bool UpdateHostSetting(string settingName, string settingValue);

        // Issue Work Reports
        int CreateNewIssueWorkReport(IssueWorkReport workReportToCreate);
        List<IssueWorkReport> GetIssueWorkReportsByIssueId(int issueId);
        bool DeleteIssueWorkReport(int issueWorkReportId);
        List<IssueWorkReport> GetIssueWorkReportsByProjectId(int projectId);
        List<IssueWorkReport> GetIssueWorkReportsByUserName(int projectId, string reporterUserName);

        // Application Log
        List<ApplicationLog> GetApplicationLog(string filterType);
        void ClearApplicationLog();

        //String Resources
        List<string> GetInstalledLanguageResources();
    }
}
