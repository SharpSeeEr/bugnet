using BugNET.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugNET.Models;
using log4net;

namespace BugNET.Providers.DataProviders
{
    public class EFDataProvider : IDataProvider
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(EFDataProvider));

        public bool SupportsProjectCloning
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool AddPermission(int roleId, int permissionId)
        {
            throw new NotImplementedException();
        }

        public bool AddUserToProject(string userName, int projectId)
        {
            throw new NotImplementedException();
        }

        public bool AddUserToRole(string userName, int roleId)
        {
            throw new NotImplementedException();
        }

        public bool CanDeleteIssueType(int issueTypeId)
        {
            throw new NotImplementedException();
        }

        public bool CanDeleteMilestone(int milestoneId)
        {
            throw new NotImplementedException();
        }

        public bool CanDeletePriority(int priorityId)
        {
            throw new NotImplementedException();
        }

        public bool CanDeleteResolution(int ResolutionId)
        {
            throw new NotImplementedException();
        }

        public bool CanDeleteStatus(int statusId)
        {
            throw new NotImplementedException();
        }

        public void ClearApplicationLog()
        {
            throw new NotImplementedException();
        }

        public int CloneProject(int projectId, string projectName, string creatorUserName = "")
        {
            throw new NotImplementedException();
        }

        public int CreateNewCategory(Category newCategory)
        {
            throw new NotImplementedException();
        }

        public int CreateNewChildIssue(int primaryIssueId, int secondaryIssueId)
        {
            throw new NotImplementedException();
        }

        public int CreateNewCustomField(CustomField newCustomField)
        {
            throw new NotImplementedException();
        }

        public int CreateNewCustomFieldSelection(CustomFieldSelection newCustomFieldSelection)
        {
            throw new NotImplementedException();
        }

        public int CreateNewIssue(Issue issueToCreate)
        {
            throw new NotImplementedException();
        }

        public int CreateNewIssueAttachment(IssueAttachment newAttachment)
        {
            throw new NotImplementedException();
        }

        public int CreateNewIssueComment(IssueComment newComment)
        {
            throw new NotImplementedException();
        }

        public int CreateNewIssueHistory(IssueHistory newHistory)
        {
            throw new NotImplementedException();
        }

        public int CreateNewIssueNotification(IssueNotification newNotification)
        {
            throw new NotImplementedException();
        }

        public int CreateNewIssueRevision(IssueRevision newIssueRevision)
        {
            throw new NotImplementedException();
        }

        public int CreateNewIssueType(IssueType issueTypeToCreate)
        {
            throw new NotImplementedException();
        }

        public int CreateNewIssueVote(IssueVote newIssueVote)
        {
            throw new NotImplementedException();
        }

        public int CreateNewIssueWorkReport(IssueWorkReport workReportToCreate)
        {
            throw new NotImplementedException();
        }

        public int CreateNewMilestone(Milestone newMileStone)
        {
            throw new NotImplementedException();
        }

        public int CreateNewParentIssue(int primaryIssueId, int secondaryIssueId)
        {
            throw new NotImplementedException();
        }

        public int CreateNewPriority(Priority newPriority)
        {
            throw new NotImplementedException();
        }

        public int CreateNewProject(Project newProject)
        {
            throw new NotImplementedException();
        }

        public int CreateNewProjectNotification(ProjectNotification newProjectNotification)
        {
            throw new NotImplementedException();
        }

        public int CreateNewRelatedIssue(int primaryIssueId, int secondaryIssueId)
        {
            throw new NotImplementedException();
        }

        public int CreateNewResolution(Resolution resolutionToCreate)
        {
            throw new NotImplementedException();
        }

        public int CreateNewRole(Role newRole)
        {
            throw new NotImplementedException();
        }

        public int CreateNewStatus(Status newStatus)
        {
            throw new NotImplementedException();
        }

        public int CreateProjectMailbox(ProjectMailbox mailboxToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteChildIssue(int primaryIssueId, int secondaryIssueId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomField(int customFieldId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomFieldSelection(int customFieldSelectionId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIssue(int issueId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIssueAttachment(int attachmentId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIssueCommentById(int commentId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIssueNotification(int issueId, string username)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIssueRevision(int issueRevisionId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIssueType(int issueTypeId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIssueWorkReport(int issueWorkReportId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMilestone(int milestoneId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteParentIssue(int primaryIssueId, int secondaryIssueId)
        {
            throw new NotImplementedException();
        }

        public bool DeletePermission(int roleId, int permissionId)
        {
            throw new NotImplementedException();
        }

        public bool DeletePriority(int priorityId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProjectImage(int projectId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProjectMailbox(int mailboxId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProjectNotification(int projectId, string username)
        {
            throw new NotImplementedException();
        }

        public bool DeleteQuery(int queryId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRelatedIssue(int primaryIssueId, int secondaryIssueId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteResolution(int resolutionId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRole(int roleId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStatus(int statusId)
        {
            throw new NotImplementedException();
        }

        public void ExecuteScript(IEnumerable<string> sql)
        {
            throw new NotImplementedException();
        }

        public List<BugNET.Common.Permission> GetAllPermissions()
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllProjects(bool? activeOnly = true)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public List<ApplicationLog> GetApplicationLog(string filterType)
        {
            throw new NotImplementedException();
        }

        public IssueAttachment GetAttachmentForDownload(int attachmentId, string requestingUser = "")
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoriesByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetChildCategoriesByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<RelatedIssue> GetChildIssues(int issueId)
        {
            throw new NotImplementedException();
        }

        public CustomField GetCustomFieldById(int customFieldId)
        {
            throw new NotImplementedException();
        }

        public List<CustomField> GetCustomFieldsByIssueId(int issueId)
        {
            throw new NotImplementedException();
        }

        public List<CustomField> GetCustomFieldsByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public CustomFieldSelection GetCustomFieldSelectionById(int customFieldSelectionId)
        {
            throw new NotImplementedException();
        }

        public List<CustomFieldSelection> GetCustomFieldSelectionsByCustomFieldId(int customFieldId)
        {
            throw new NotImplementedException();
        }

        public string GetDatabaseVersion()
        {
            throw new NotImplementedException();
        }

        public List<DefaultValue> GetDefaultIssueTypeByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public List<HostSetting> GetHostSettings()
        {
            throw new NotImplementedException();
        }

        public List<string> GetInstalledLanguageResources()
        {
            throw new NotImplementedException();
        }

        public IssueAttachment GetIssueAttachmentById(int attachmentId)
        {
            throw new NotImplementedException();
        }

        public List<IssueAttachment> GetIssueAttachmentsByIssueId(int issueId)
        {
            throw new NotImplementedException();
        }

        public Issue GetIssueById(int issueId)
        {
            throw new NotImplementedException();
        }

        public IssueComment GetIssueCommentById(int issueCommentId)
        {
            throw new NotImplementedException();
        }

        public List<IssueComment> GetIssueCommentsByIssueId(int issueId)
        {
            throw new NotImplementedException();
        }

        public int GetIssueCountByProjectAndCategory(int projectId, int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<IssueHistory> GetIssueHistoryByIssueId(int issueId)
        {
            throw new NotImplementedException();
        }

        public List<IssueNotification> GetIssueNotificationsByIssueId(int issueId)
        {
            throw new NotImplementedException();
        }

        public List<IssueRevision> GetIssueRevisionsByIssueId(int issueId)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetIssuesByAssignedUserName(int projectId, string assignedUserName)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetIssuesByCreatorUserName(int projectId, string creatorUserName)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetIssuesByOwnerUserName(int projectId, string creatorUserName)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetIssuesByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetIssuesByRelevancy(int projectId, string username)
        {
            throw new NotImplementedException();
        }

        public IssueType GetIssueTypeById(int issueTypeId)
        {
            throw new NotImplementedException();
        }

        public List<IssueType> GetIssueTypesByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public int GetIssueUnassignedCountByProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public int GetIssueUnscheduledMilestoneCountByProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public List<IssueWorkReport> GetIssueWorkReportsByIssueId(int issueId)
        {
            throw new NotImplementedException();
        }

        public List<IssueWorkReport> GetIssueWorkReportsByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public List<IssueWorkReport> GetIssueWorkReportsByUserName(int projectId, string reporterUserName)
        {
            throw new NotImplementedException();
        }

        public List<ProjectMailbox> GetMailboxsByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public Milestone GetMilestoneById(int milestoneId)
        {
            throw new NotImplementedException();
        }

        public List<Milestone> GetMilestonesByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public List<Milestone> GetMilestonesByProjectId(int projectId, bool notCompleted)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetMonitoredIssuesByUserName(string userName, bool excludeClosedStatus)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetMonitoredIssuesByUserName(object userId, ICollection<KeyValuePair<string, string>> sortFields, List<int> projects, bool excludeClosedStatus)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetOpenIssues(int projectId)
        {
            throw new NotImplementedException();
        }

        public List<RelatedIssue> GetParentIssues(int issueId)
        {
            throw new NotImplementedException();
        }

        public List<BugNET.Common.Permission> GetPermissionsByRoleId(int roleId)
        {
            throw new NotImplementedException();
        }

        public List<Priority> GetPrioritiesByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public Priority GetPriorityById(int priorityId)
        {
            throw new NotImplementedException();
        }

        public Project GetProjectByCode(string projectCode)
        {
            throw new NotImplementedException();
        }

        public Project GetProjectById(int projectId)
        {
            throw new NotImplementedException();
        }

        public ProjectMailbox GetProjectByMailbox(string mailbox)
        {
            throw new NotImplementedException();
        }

        public ProjectMailbox GetProjectMailboxByMailboxId(int projectMailboxId)
        {
            throw new NotImplementedException();
        }

        public List<ProjectNotification> GetProjectNotificationsByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public List<ProjectNotification> GetProjectNotificationsByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public int[] GetProjectRoadmapProgress(int projectId, int milestoneId)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjectsByMemberUserName(string username)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjectsByMemberUserName(string userName, bool activeOnly)
        {
            throw new NotImplementedException();
        }

        public string GetProviderPath()
        {
            throw new NotImplementedException();
        }

        public List<Project> GetPublicProjects()
        {
            throw new NotImplementedException();
        }

        public List<Query> GetQueriesByUserName(string username, int projectId)
        {
            throw new NotImplementedException();
        }

        public Query GetQueryById(int queryId)
        {
            throw new NotImplementedException();
        }

        public List<QueryClause> GetQueryClausesByQueryId(int queryId)
        {
            throw new NotImplementedException();
        }

        public List<RelatedIssue> GetRelatedIssues(int issueId)
        {
            throw new NotImplementedException();
        }

        public List<RequiredField> GetRequiredFieldsForIssues()
        {
            throw new NotImplementedException();
        }

        public Resolution GetResolutionById(int resolutionId)
        {
            throw new NotImplementedException();
        }

        public List<Resolution> GetResolutionsByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public Role GetRoleById(int roleId)
        {
            throw new NotImplementedException();
        }

        public List<RolePermission> GetRolePermissions()
        {
            throw new NotImplementedException();
        }

        public List<Role> GetRolesByProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetRolesByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetRolesByUserName(string userName, int projectId)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetRootCategoriesByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public string GetSelectedIssueColumnsByUserName(string userName, int projectId)
        {
            throw new NotImplementedException();
        }

        public Status GetStatusById(int statusId)
        {
            throw new NotImplementedException();
        }

        public List<Status> GetStatusByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public string GetUserNameByPasswordResetToken(string token)
        {
            throw new NotImplementedException();
        }

        public bool HasUserVoted(int issueId, string username)
        {
            throw new NotImplementedException();
        }

        public bool IsUserProjectMember(string userName, int projectId)
        {
            throw new NotImplementedException();
        }

        public void PerformIssueCommentSearchQuery(ref List<IssueComment> list, List<QueryClause> queryClauses)
        {
            throw new NotImplementedException();
        }

        public List<Issue> PerformQuery(List<QueryClause> queryClauses, ICollection<KeyValuePair<string, string>> sortFields, int projectId = 0)
        {
            throw new NotImplementedException();
        }

        public List<Issue> PerformSavedQuery(int projectId, int queryId, ICollection<KeyValuePair<string, string>> sortFields)
        {
            throw new NotImplementedException();
        }

        public BugNET.Common.DataAccessException ProcessException(Exception ex)
        {
            throw new NotImplementedException();
        }

        public bool RemoveUserFromProject(string userName, int projectId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveUserFromRole(string userName, int roleId)
        {
            throw new NotImplementedException();
        }

        public bool RoleExists(string roleName, int projectId)
        {
            throw new NotImplementedException();
        }

        public bool SaveCustomFieldValues(int issueId, List<CustomField> fields)
        {
            throw new NotImplementedException();
        }

        public bool SaveQuery(string username, int projectId, string queryName, bool isPublic, List<QueryClause> queryClauses)
        {
            throw new NotImplementedException();
        }

        public bool SetDefaultIssueTypeByProjectId(DefaultValue defaultVal)
        {
            throw new NotImplementedException();
        }

        public void SetSelectedIssueColumnsByUserName(string userName, int projectId, string columns)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(Category categoryToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomField(CustomField customFieldToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomFieldSelection(CustomFieldSelection customFieldSelectionToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool UpdateHostSetting(string settingName, string settingValue)
        {
            throw new NotImplementedException();
        }

        public bool UpdateIssue(Issue issueToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool UpdateIssueComment(IssueComment issueCommentToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool UpdateIssueLastUpdated(int issueId, string lastUpdatedUsername)
        {
            throw new NotImplementedException();
        }

        public bool UpdateIssueType(IssueType issueTypeToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMilestone(Milestone milestoneToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePriority(Priority priorityToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProject(Project projectToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProjectMailbox(ProjectMailbox mailboxToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool UpdateQuery(int queryId, string username, int projectId, string queryName, bool isPublic, List<QueryClause> queryClauses)
        {
            throw new NotImplementedException();
        }

        public bool UpdateResolution(Resolution resolutionToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRole(Role roleToUpdate)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStatus(Status statusToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
