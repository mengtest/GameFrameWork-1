// Code generated by protogen.
// DO NOT EDIT!!!
// source:  TaskService.proto
//
using CitrusNet;
using CitrusNet.Phobos;

namespace PhobosRpc {
    
    public class TaskService
    {
        private RpcInvoker mInvoker;
        
        public TaskService(RpcInvoker invoker)
        {
            mInvoker = invoker;
        }
        
        /// <summary>
        /// list all task.
        /// </summary>
        public void ListTaskAsync(
            RpcCallback<ListTaskReply> callback
        ) {
            var parameters = new ListTaskArgs {
            };
    
            ListTaskAsync(parameters, callback);
        }
        
        /// <summary>
        /// list all task.
        /// </summary>
        public void ListTaskAsync(ListTaskArgs args, RpcCallback<ListTaskReply> callback) {
            mInvoker.Call($"player,route", args, callback);
        }
        
        /// <summary>
        /// get task with id.
        /// </summary>
        /// <param name="taskId">taskId</param>
        public void GetTaskAsync(
            int taskId,
            RpcCallback<GetTaskReply> callback
        ) {
            var parameters = new GetTaskArgs {
                taskId = taskId,
            };
    
            GetTaskAsync(parameters, callback);
        }
        
        /// <summary>
        /// get task with id.
        /// </summary>
        public void GetTaskAsync(GetTaskArgs args, RpcCallback<GetTaskReply> callback) {
            mInvoker.Call($"player,route", args, callback);
        }
        
        /// <summary>
        /// add new task.
        /// </summary>
        /// <param name="taskName">taskName</param>
        /// <param name="taskTime">taskTime</param>
        public void AddTaskAsync(
            string taskName,
            long taskTime,
            RpcCallback<AddTaskReply> callback
        ) {
            var parameters = new AddTaskArgs {
                taskName = taskName,
                taskTime = taskTime,
            };
    
            AddTaskAsync(parameters, callback);
        }
        
        /// <summary>
        /// add new task.
        /// </summary>
        public void AddTaskAsync(AddTaskArgs args, RpcCallback<AddTaskReply> callback) {
            mInvoker.Call($"player,route", args, callback);
        }
        
        /// <summary>
        /// delete task with id.
        /// </summary>
        /// <param name="taskId">taskId</param>
        public void DelTaskAsync(
            int taskId,
            RpcCallback<DelTaskReply> callback
        ) {
            var parameters = new DelTaskArgs {
                taskId = taskId,
            };
    
            DelTaskAsync(parameters, callback);
        }
        
        /// <summary>
        /// delete task with id.
        /// </summary>
        public void DelTaskAsync(DelTaskArgs args, RpcCallback<DelTaskReply> callback) {
            mInvoker.Call($"player,route", args, callback);
        }

        public void Login(RpcCallback<DelTaskReply> callback)
        {
            var parameters = new PlayerLogin
            {
                token = 11010,
            };
            mInvoker.Call($"route,player", parameters, callback);
        }
        
    }


    
    [ProtoBuf.ProtoContract]
    public class ListTaskArgs : NetCommand {
    }

    
    [ProtoBuf.ProtoContract]
    public class ListTaskReply : NetCommand {
    }

    
    [ProtoBuf.ProtoContract]
    public class GetTaskArgs : NetCommand {
        
        [ProtoBuf.ProtoMember(1)]
        public int taskId { get; set; }
    }

    
    [ProtoBuf.ProtoContract]
    public class GetTaskReply : NetCommand {
    }

    
    [ProtoBuf.ProtoContract]
    public class AddTaskArgs : NetCommand {
        
        [ProtoBuf.ProtoMember(1)]
        public string taskName { get; set; }
        
        [ProtoBuf.ProtoMember(2)]
        public long taskTime { get; set; }
    }

    
    [ProtoBuf.ProtoContract]
    public class AddTaskReply : NetCommand {
    }

    
    [ProtoBuf.ProtoContract]
    public class DelTaskArgs : NetCommand {
        
        [ProtoBuf.ProtoMember(1)]
        public int taskId { get; set; }
    }

    
    [ProtoBuf.ProtoContract]
    public class DelTaskReply : NetCommand {
    }

    [ProtoBuf.ProtoContract]
    public class PlayerLogin : NetCommand
    {
        public int token { get; set; }
    }
}