﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoadTex
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RoadTex_MVCEntities : DbContext
    {
        public RoadTex_MVCEntities()
            : base("name=RoadTex_MVCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCustomer> tblCustomers { get; set; }
        public virtual DbSet<tblPermission> tblPermissions { get; set; }
        public virtual DbSet<tblRegion> tblRegions { get; set; }
        public virtual DbSet<tblRole> tblRoles { get; set; }
        public virtual DbSet<tblRole_Permission> tblRole_Permission { get; set; }
        public virtual DbSet<tblState> tblStates { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
    
        public virtual int sp_AddNewRole(string roleName)
        {
            var roleNameParameter = roleName != null ?
                new ObjectParameter("roleName", roleName) :
                new ObjectParameter("roleName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddNewRole", roleNameParameter);
        }
    
        public virtual int sp_AddRegion(string regionName, string regionDescription)
        {
            var regionNameParameter = regionName != null ?
                new ObjectParameter("regionName", regionName) :
                new ObjectParameter("regionName", typeof(string));
    
            var regionDescriptionParameter = regionDescription != null ?
                new ObjectParameter("regionDescription", regionDescription) :
                new ObjectParameter("regionDescription", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddRegion", regionNameParameter, regionDescriptionParameter);
        }
    
        public virtual int sp_AddState(string stateName, Nullable<int> regionId)
        {
            var stateNameParameter = stateName != null ?
                new ObjectParameter("stateName", stateName) :
                new ObjectParameter("stateName", typeof(string));
    
            var regionIdParameter = regionId.HasValue ?
                new ObjectParameter("regionId", regionId) :
                new ObjectParameter("regionId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddState", stateNameParameter, regionIdParameter);
        }
    
        public virtual int sp_cm_create_customers(string customer_name, string contact_name, Nullable<bool> customer_status, Nullable<int> sales_rep, Nullable<int> preparer, Nullable<int> customer_priority, Nullable<int> follow_up_type, Nullable<System.DateTime> follow_up_date, Nullable<int> state_id)
        {
            var customer_nameParameter = customer_name != null ?
                new ObjectParameter("customer_name", customer_name) :
                new ObjectParameter("customer_name", typeof(string));
    
            var contact_nameParameter = contact_name != null ?
                new ObjectParameter("contact_name", contact_name) :
                new ObjectParameter("contact_name", typeof(string));
    
            var customer_statusParameter = customer_status.HasValue ?
                new ObjectParameter("customer_status", customer_status) :
                new ObjectParameter("customer_status", typeof(bool));
    
            var sales_repParameter = sales_rep.HasValue ?
                new ObjectParameter("sales_rep", sales_rep) :
                new ObjectParameter("sales_rep", typeof(int));
    
            var preparerParameter = preparer.HasValue ?
                new ObjectParameter("preparer", preparer) :
                new ObjectParameter("preparer", typeof(int));
    
            var customer_priorityParameter = customer_priority.HasValue ?
                new ObjectParameter("customer_priority", customer_priority) :
                new ObjectParameter("customer_priority", typeof(int));
    
            var follow_up_typeParameter = follow_up_type.HasValue ?
                new ObjectParameter("follow_up_type", follow_up_type) :
                new ObjectParameter("follow_up_type", typeof(int));
    
            var follow_up_dateParameter = follow_up_date.HasValue ?
                new ObjectParameter("follow_up_date", follow_up_date) :
                new ObjectParameter("follow_up_date", typeof(System.DateTime));
    
            var state_idParameter = state_id.HasValue ?
                new ObjectParameter("state_id", state_id) :
                new ObjectParameter("state_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_cm_create_customers", customer_nameParameter, contact_nameParameter, customer_statusParameter, sales_repParameter, preparerParameter, customer_priorityParameter, follow_up_typeParameter, follow_up_dateParameter, state_idParameter);
        }
    
        public virtual int sp_cm_delete_customers(Nullable<int> customer_id)
        {
            var customer_idParameter = customer_id.HasValue ?
                new ObjectParameter("customer_id", customer_id) :
                new ObjectParameter("customer_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_cm_delete_customers", customer_idParameter);
        }
    
        public virtual ObjectResult<sp_cm_select_customers_Result> sp_cm_select_customers(string customer_name, string contact_name, Nullable<int> sales_rep, Nullable<int> preparer, Nullable<int> status, Nullable<int> follow_up_type)
        {
            var customer_nameParameter = customer_name != null ?
                new ObjectParameter("customer_name", customer_name) :
                new ObjectParameter("customer_name", typeof(string));
    
            var contact_nameParameter = contact_name != null ?
                new ObjectParameter("contact_name", contact_name) :
                new ObjectParameter("contact_name", typeof(string));
    
            var sales_repParameter = sales_rep.HasValue ?
                new ObjectParameter("sales_rep", sales_rep) :
                new ObjectParameter("sales_rep", typeof(int));
    
            var preparerParameter = preparer.HasValue ?
                new ObjectParameter("preparer", preparer) :
                new ObjectParameter("preparer", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            var follow_up_typeParameter = follow_up_type.HasValue ?
                new ObjectParameter("follow_up_type", follow_up_type) :
                new ObjectParameter("follow_up_type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_cm_select_customers_Result>("sp_cm_select_customers", customer_nameParameter, contact_nameParameter, sales_repParameter, preparerParameter, statusParameter, follow_up_typeParameter);
        }
    
        public virtual int sp_cm_update_customers(string customer_name, string contact_name, Nullable<bool> customer_status, Nullable<int> sales_rep, Nullable<int> preparer, Nullable<int> customer_priority, Nullable<int> follow_up_type, Nullable<System.DateTime> follow_up_date, Nullable<int> state_id, Nullable<int> customer_id)
        {
            var customer_nameParameter = customer_name != null ?
                new ObjectParameter("customer_name", customer_name) :
                new ObjectParameter("customer_name", typeof(string));
    
            var contact_nameParameter = contact_name != null ?
                new ObjectParameter("contact_name", contact_name) :
                new ObjectParameter("contact_name", typeof(string));
    
            var customer_statusParameter = customer_status.HasValue ?
                new ObjectParameter("customer_status", customer_status) :
                new ObjectParameter("customer_status", typeof(bool));
    
            var sales_repParameter = sales_rep.HasValue ?
                new ObjectParameter("sales_rep", sales_rep) :
                new ObjectParameter("sales_rep", typeof(int));
    
            var preparerParameter = preparer.HasValue ?
                new ObjectParameter("preparer", preparer) :
                new ObjectParameter("preparer", typeof(int));
    
            var customer_priorityParameter = customer_priority.HasValue ?
                new ObjectParameter("customer_priority", customer_priority) :
                new ObjectParameter("customer_priority", typeof(int));
    
            var follow_up_typeParameter = follow_up_type.HasValue ?
                new ObjectParameter("follow_up_type", follow_up_type) :
                new ObjectParameter("follow_up_type", typeof(int));
    
            var follow_up_dateParameter = follow_up_date.HasValue ?
                new ObjectParameter("follow_up_date", follow_up_date) :
                new ObjectParameter("follow_up_date", typeof(System.DateTime));
    
            var state_idParameter = state_id.HasValue ?
                new ObjectParameter("state_id", state_id) :
                new ObjectParameter("state_id", typeof(int));
    
            var customer_idParameter = customer_id.HasValue ?
                new ObjectParameter("customer_id", customer_id) :
                new ObjectParameter("customer_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_cm_update_customers", customer_nameParameter, contact_nameParameter, customer_statusParameter, sales_repParameter, preparerParameter, customer_priorityParameter, follow_up_typeParameter, follow_up_dateParameter, state_idParameter, customer_idParameter);
        }
    
        public virtual int sp_DeleteRole(string roleName)
        {
            var roleNameParameter = roleName != null ?
                new ObjectParameter("roleName", roleName) :
                new ObjectParameter("roleName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteRole", roleNameParameter);
        }
    
        public virtual int sp_DeleteState(string stateName)
        {
            var stateNameParameter = stateName != null ?
                new ObjectParameter("stateName", stateName) :
                new ObjectParameter("stateName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteState", stateNameParameter);
        }
    
        public virtual ObjectResult<sp_GetCustomers_Result> sp_GetCustomers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetCustomers_Result>("sp_GetCustomers");
        }
    
        public virtual ObjectResult<sp_getRole_Result> sp_getRole(Nullable<int> role)
        {
            var roleParameter = role.HasValue ?
                new ObjectParameter("Role", role) :
                new ObjectParameter("Role", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getRole_Result>("sp_getRole", roleParameter);
        }
    
        public virtual int sp_p_create_permission(string permission)
        {
            var permissionParameter = permission != null ?
                new ObjectParameter("permission", permission) :
                new ObjectParameter("permission", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_p_create_permission", permissionParameter);
        }
    
        public virtual int sp_ResetPassword(string emailAdd, string confirmPass)
        {
            var emailAddParameter = emailAdd != null ?
                new ObjectParameter("emailAdd", emailAdd) :
                new ObjectParameter("emailAdd", typeof(string));
    
            var confirmPassParameter = confirmPass != null ?
                new ObjectParameter("confirmPass", confirmPass) :
                new ObjectParameter("confirmPass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ResetPassword", emailAddParameter, confirmPassParameter);
        }
    
        public virtual int sp_rp_create_roleperm(Nullable<int> role_id, Nullable<int> perm_id, Nullable<bool> edit_perm, Nullable<bool> view_perm)
        {
            var role_idParameter = role_id.HasValue ?
                new ObjectParameter("role_id", role_id) :
                new ObjectParameter("role_id", typeof(int));
    
            var perm_idParameter = perm_id.HasValue ?
                new ObjectParameter("perm_id", perm_id) :
                new ObjectParameter("perm_id", typeof(int));
    
            var edit_permParameter = edit_perm.HasValue ?
                new ObjectParameter("edit_perm", edit_perm) :
                new ObjectParameter("edit_perm", typeof(bool));
    
            var view_permParameter = view_perm.HasValue ?
                new ObjectParameter("view_perm", view_perm) :
                new ObjectParameter("view_perm", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_rp_create_roleperm", role_idParameter, perm_idParameter, edit_permParameter, view_permParameter);
        }
    
        public virtual ObjectResult<sp_rp_select_roleperm_Result> sp_rp_select_roleperm(Nullable<int> role_id, Nullable<int> perm_id)
        {
            var role_idParameter = role_id.HasValue ?
                new ObjectParameter("role_id", role_id) :
                new ObjectParameter("role_id", typeof(int));
    
            var perm_idParameter = perm_id.HasValue ?
                new ObjectParameter("perm_id", perm_id) :
                new ObjectParameter("perm_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_rp_select_roleperm_Result>("sp_rp_select_roleperm", role_idParameter, perm_idParameter);
        }
    
        public virtual ObjectResult<sp_Search_Result> sp_Search(string searchParam)
        {
            var searchParamParameter = searchParam != null ?
                new ObjectParameter("searchParam", searchParam) :
                new ObjectParameter("searchParam", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Search_Result>("sp_Search", searchParamParameter);
        }
    
        public virtual ObjectResult<sp_SelectStates_Result> sp_SelectStates()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_SelectStates_Result>("sp_SelectStates");
        }
    
        public virtual int sp_um_create_user(string firstName, string lastName, string email, string password, Nullable<int> roleID, Nullable<bool> isSalesRep, Nullable<bool> isPreparer)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var roleIDParameter = roleID.HasValue ?
                new ObjectParameter("RoleID", roleID) :
                new ObjectParameter("RoleID", typeof(int));
    
            var isSalesRepParameter = isSalesRep.HasValue ?
                new ObjectParameter("IsSalesRep", isSalesRep) :
                new ObjectParameter("IsSalesRep", typeof(bool));
    
            var isPreparerParameter = isPreparer.HasValue ?
                new ObjectParameter("IsPreparer", isPreparer) :
                new ObjectParameter("IsPreparer", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_um_create_user", firstNameParameter, lastNameParameter, emailParameter, passwordParameter, roleIDParameter, isSalesRepParameter, isPreparerParameter);
        }
    
        public virtual int sp_um_delete_user(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_um_delete_user", userIDParameter);
        }
    
        public virtual ObjectResult<sp_um_select_user_Result> sp_um_select_user()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_um_select_user_Result>("sp_um_select_user");
        }
    
        public virtual int sp_um_update_user(string first_name, string last_name, string e_mail, Nullable<int> user_role_id, Nullable<bool> isSalesRep, Nullable<bool> isPreparer, Nullable<int> user_id)
        {
            var first_nameParameter = first_name != null ?
                new ObjectParameter("first_name", first_name) :
                new ObjectParameter("first_name", typeof(string));
    
            var last_nameParameter = last_name != null ?
                new ObjectParameter("last_name", last_name) :
                new ObjectParameter("last_name", typeof(string));
    
            var e_mailParameter = e_mail != null ?
                new ObjectParameter("e_mail", e_mail) :
                new ObjectParameter("e_mail", typeof(string));
    
            var user_role_idParameter = user_role_id.HasValue ?
                new ObjectParameter("user_role_id", user_role_id) :
                new ObjectParameter("user_role_id", typeof(int));
    
            var isSalesRepParameter = isSalesRep.HasValue ?
                new ObjectParameter("isSalesRep", isSalesRep) :
                new ObjectParameter("isSalesRep", typeof(bool));
    
            var isPreparerParameter = isPreparer.HasValue ?
                new ObjectParameter("isPreparer", isPreparer) :
                new ObjectParameter("isPreparer", typeof(bool));
    
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_um_update_user", first_nameParameter, last_nameParameter, e_mailParameter, user_role_idParameter, isSalesRepParameter, isPreparerParameter, user_idParameter);
        }
    
        public virtual ObjectResult<sp_UpdatedRow_Result> sp_UpdatedRow(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_UpdatedRow_Result>("sp_UpdatedRow", idParameter);
        }
    
        public virtual int sp_UpdateRole(string newRoleName, string oldRoleName)
        {
            var newRoleNameParameter = newRoleName != null ?
                new ObjectParameter("newRoleName", newRoleName) :
                new ObjectParameter("newRoleName", typeof(string));
    
            var oldRoleNameParameter = oldRoleName != null ?
                new ObjectParameter("oldRoleName", oldRoleName) :
                new ObjectParameter("oldRoleName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateRole", newRoleNameParameter, oldRoleNameParameter);
        }
    
        public virtual int sp_UpdateState(Nullable<int> stateId, string newStateName)
        {
            var stateIdParameter = stateId.HasValue ?
                new ObjectParameter("stateId", stateId) :
                new ObjectParameter("stateId", typeof(int));
    
            var newStateNameParameter = newStateName != null ?
                new ObjectParameter("newStateName", newStateName) :
                new ObjectParameter("newStateName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateState", stateIdParameter, newStateNameParameter);
        }
    }
}
