﻿using System;

namespace Smartstore.Scheduling
{
    public sealed class TaskActivationException : Exception
    {
        public TaskActivationException()
            : base()
        {
        }

        public TaskActivationException(string message)
            : base(message)
        {
        }

        public TaskActivationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// Responsible for activating <see cref="ITask"/> implementation instances.
    /// </summary>
    public interface ITaskActivator
    {
        /// <summary>
        /// Gets the normalized type name used by DI to resolve the task implementation.
        /// Usually this is the simple type name from <see cref="TaskDescriptor.Type"/>, but in legacy versions of Smartstore
        /// the assembly qualified CLR type name has been used. In this case, the simple type name is extracted from
        /// assembly qualified type.
        /// </summary>
        /// <param name="task">The task descriptor.</param>
        /// <returns>The normalized task type name.</returns>
        string GetNormalizedTypeName(TaskDescriptor task);

        /// <summary>
        /// Resolves the CLR <see cref="Type"/> of a task.
        /// </summary>
        Type GetTaskClrType(string normalizedTypeName);

        /// <summary>
        /// Instantiates an <see cref="ITask"/> implementation instance per DI.
        /// </summary>
        ITask Activate(string normalizedTypeName);
    }
}
