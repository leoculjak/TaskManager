﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MyCompany.Data;

namespace MyCompany.Models
{
    public enum TasksDataField
    {

        ID,

        Description,

        Date,

        Created,

        Completed,

        LocationId,

        LocationName,

        LocationAddress,

        LocationCity,

        LocationState,

        LocationZip,

        LocationCountry,

        Creator,

        Owner,

        Status,

        CreatedBy,

        StartDate,

        EndDate,

        ScheduleDaysOfWeek,

        ScheduleWeeks,

        ScheduleId,

        Tags,
    }

    public partial class TasksModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iD;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _description;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _date;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _created;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _completed;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _locationId;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationAddress;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationCity;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationState;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationZip;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationCountry;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creator;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _owner;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _status;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _startDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _endDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _scheduleDaysOfWeek;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _scheduleWeeks;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _scheduleId;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tags;

        public TasksModel()
        {
        }

        public TasksModel(BusinessRules r) :
                base(r)
        {
        }

        public int? ID
        {
            get
            {
                return _iD;
            }
            set
            {
                _iD = value;
                UpdateFieldValue("ID", value);
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                UpdateFieldValue("Description", value);
            }
        }

        public DateTime? Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                UpdateFieldValue("Date", value);
            }
        }

        public DateTime? Created
        {
            get
            {
                return _created;
            }
            set
            {
                _created = value;
                UpdateFieldValue("Created", value);
            }
        }

        public DateTime? Completed
        {
            get
            {
                return _completed;
            }
            set
            {
                _completed = value;
                UpdateFieldValue("Completed", value);
            }
        }

        public int? LocationId
        {
            get
            {
                return _locationId;
            }
            set
            {
                _locationId = value;
                UpdateFieldValue("LocationId", value);
            }
        }

        public string LocationName
        {
            get
            {
                return _locationName;
            }
            set
            {
                _locationName = value;
                UpdateFieldValue("LocationName", value);
            }
        }

        public string LocationAddress
        {
            get
            {
                return _locationAddress;
            }
            set
            {
                _locationAddress = value;
                UpdateFieldValue("LocationAddress", value);
            }
        }

        public string LocationCity
        {
            get
            {
                return _locationCity;
            }
            set
            {
                _locationCity = value;
                UpdateFieldValue("LocationCity", value);
            }
        }

        public string LocationState
        {
            get
            {
                return _locationState;
            }
            set
            {
                _locationState = value;
                UpdateFieldValue("LocationState", value);
            }
        }

        public string LocationZip
        {
            get
            {
                return _locationZip;
            }
            set
            {
                _locationZip = value;
                UpdateFieldValue("LocationZip", value);
            }
        }

        public string LocationCountry
        {
            get
            {
                return _locationCountry;
            }
            set
            {
                _locationCountry = value;
                UpdateFieldValue("LocationCountry", value);
            }
        }

        public string Creator
        {
            get
            {
                return _creator;
            }
            set
            {
                _creator = value;
                UpdateFieldValue("Creator", value);
            }
        }

        public string Owner
        {
            get
            {
                return _owner;
            }
            set
            {
                _owner = value;
                UpdateFieldValue("Owner", value);
            }
        }

        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                UpdateFieldValue("Status", value);
            }
        }

        public int? CreatedBy
        {
            get
            {
                return _createdBy;
            }
            set
            {
                _createdBy = value;
                UpdateFieldValue("CreatedBy", value);
            }
        }

        public DateTime? StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                UpdateFieldValue("StartDate", value);
            }
        }

        public DateTime? EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
                UpdateFieldValue("EndDate", value);
            }
        }

        public string ScheduleDaysOfWeek
        {
            get
            {
                return _scheduleDaysOfWeek;
            }
            set
            {
                _scheduleDaysOfWeek = value;
                UpdateFieldValue("ScheduleDaysOfWeek", value);
            }
        }

        public int? ScheduleWeeks
        {
            get
            {
                return _scheduleWeeks;
            }
            set
            {
                _scheduleWeeks = value;
                UpdateFieldValue("ScheduleWeeks", value);
            }
        }

        public int? ScheduleId
        {
            get
            {
                return _scheduleId;
            }
            set
            {
                _scheduleId = value;
                UpdateFieldValue("ScheduleId", value);
            }
        }

        public string Tags
        {
            get
            {
                return _tags;
            }
            set
            {
                _tags = value;
                UpdateFieldValue("Tags", value);
            }
        }

        public FieldValue this[TasksDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class Tasks : TasksModel
    {

        public static List<MyCompany.Models.Tasks> Select(string filter, string sort, string dataView, params object[] parameters)
        {
            return new TasksFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<MyCompany.Models.Tasks> Select(string filter, string sort, params object[] parameters)
        {
            return new TasksFactory().Select(filter, sort, TasksFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<MyCompany.Models.Tasks> Select(string filter, params object[] parameters)
        {
            return new TasksFactory().Select(filter, null, TasksFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static MyCompany.Models.Tasks SelectSingle(string filter, params object[] parameters)
        {
            return new TasksFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static MyCompany.Models.Tasks SelectSingle(int? iD)
        {
            return new TasksFactory().SelectSingle(iD);
        }

        public int Insert()
        {
            return new TasksFactory().Insert(this);
        }

        public int Update()
        {
            return new TasksFactory().Update(this);
        }

        public int Delete()
        {
            return new TasksFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("ID: {0}", this.ID);
        }

        public static MyCompany.Models.Tasks SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<MyCompany.Models.Tasks> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<MyCompany.Models.Tasks> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<MyCompany.Models.Tasks> Select(object filter)
        {
            return Select(filter, null);
        }

        public static MyCompany.Models.Tasks Insert(object initializer)
        {
            var instance = CreateInstance<MyCompany.Models.Tasks>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<MyCompany.Models.Tasks> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<MyCompany.Models.Tasks> SelectAll(string sort)
        {
            return new MyCompany.Models.TasksFactory().Select(null, sort, MyCompany.Models.TasksFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class TasksFactory
    {

        public TasksFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Tasks");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Tasks");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Tasks");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Tasks");
            }
        }

        public static TasksFactory Create()
        {
            return new TasksFactory();
        }

        public List<MyCompany.Models.Tasks> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<MyCompany.Models.Tasks> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<MyCompany.Models.Tasks> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            var request = new PageRequest(0, Int32.MaxValue, sort, new string[0])
            {
                RequiresMetaData = true,
                MetadataFilter = new string[] {
                    "fields"}
            };
            var c = ControllerFactory.CreateDataController();
            var bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            var page = c.GetPage("Tasks", dataView, request);
            return page.ToList<MyCompany.Models.Tasks>();
        }

        public MyCompany.Models.Tasks SelectSingle(int? iD)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = iD;
            return SelectSingle(string.Format("ID={0}objpk0", parameterMarker), paramValues);
        }

        public MyCompany.Models.Tasks SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(MyCompany.Models.Tasks theTasks, MyCompany.Models.Tasks original_Tasks)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("ID", original_Tasks.ID, theTasks.ID, true));
            values.Add(new FieldValue("Description", original_Tasks.Description, theTasks.Description));
            values.Add(new FieldValue("Date", original_Tasks.Date, theTasks.Date));
            values.Add(new FieldValue("Created", original_Tasks.Created, theTasks.Created));
            values.Add(new FieldValue("Completed", original_Tasks.Completed, theTasks.Completed));
            values.Add(new FieldValue("LocationId", original_Tasks.LocationId, theTasks.LocationId));
            values.Add(new FieldValue("LocationName", original_Tasks.LocationName, theTasks.LocationName, true));
            values.Add(new FieldValue("LocationAddress", original_Tasks.LocationAddress, theTasks.LocationAddress, true));
            values.Add(new FieldValue("LocationCity", original_Tasks.LocationCity, theTasks.LocationCity, true));
            values.Add(new FieldValue("LocationState", original_Tasks.LocationState, theTasks.LocationState, true));
            values.Add(new FieldValue("LocationZip", original_Tasks.LocationZip, theTasks.LocationZip, true));
            values.Add(new FieldValue("LocationCountry", original_Tasks.LocationCountry, theTasks.LocationCountry, true));
            values.Add(new FieldValue("Creator", original_Tasks.Creator, theTasks.Creator));
            values.Add(new FieldValue("Owner", original_Tasks.Owner, theTasks.Owner));
            values.Add(new FieldValue("Status", original_Tasks.Status, theTasks.Status));
            values.Add(new FieldValue("CreatedBy", original_Tasks.CreatedBy, theTasks.CreatedBy));
            values.Add(new FieldValue("StartDate", original_Tasks.StartDate, theTasks.StartDate));
            values.Add(new FieldValue("EndDate", original_Tasks.EndDate, theTasks.EndDate));
            values.Add(new FieldValue("ScheduleDaysOfWeek", original_Tasks.ScheduleDaysOfWeek, theTasks.ScheduleDaysOfWeek));
            values.Add(new FieldValue("ScheduleWeeks", original_Tasks.ScheduleWeeks, theTasks.ScheduleWeeks));
            values.Add(new FieldValue("ScheduleId", original_Tasks.ScheduleId, theTasks.ScheduleId));
            values.Add(new FieldValue("Tags", original_Tasks.Tags, theTasks.Tags));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(MyCompany.Models.Tasks theTasks, MyCompany.Models.Tasks original_Tasks, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "Tasks",
                View = dataView,
                Values = CreateFieldValues(theTasks, original_Tasks),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("Tasks", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theTasks);
            return result.RowsAffected;
        }

        public virtual int Update(MyCompany.Models.Tasks theTasks, MyCompany.Models.Tasks original_Tasks)
        {
            return ExecuteAction(theTasks, original_Tasks, "Edit", "Update", UpdateView);
        }

        public virtual int Update(MyCompany.Models.Tasks theTasks)
        {
            return Update(theTasks, SelectSingle(theTasks.ID));
        }

        public virtual int Insert(MyCompany.Models.Tasks theTasks)
        {
            return ExecuteAction(theTasks, new Tasks(), "New", "Insert", InsertView);
        }

        public virtual int Delete(MyCompany.Models.Tasks theTasks)
        {
            return ExecuteAction(theTasks, theTasks, "Select", "Delete", DeleteView);
        }
    }
}