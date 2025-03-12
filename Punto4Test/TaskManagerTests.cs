using System;
using Xunit;
using Patrones.Punto4.Service;
using Patrones.Punto4.Commands;
using Patrones.Punto4.Models;
public class TaskManagerTests
{

    [Fact]
    public void Rename_ShouldUpdateTaskName()
    {
        // Arrange
        var task = new UserTask(1, "Old Name");

        // Act
        task.Rename("New Name");

        // Assert
        Assert.Equal("New Name", task.Name);
    }

    [Fact]
    public void Rename_ShouldThrowExceptionIfNewNameIsInvalid()
    {
        // Arrange
        var task = new UserTask(1, "Valid Name");

        // Act & Assert
        Assert.Throws<ArgumentException>(() => task.Rename(""));
    }

    [Fact]
    public void MarkAsCompleted_ShouldChangeTaskStatus()
    {
        // Arrange
        var task = new UserTask(1, "Task");

        // Act
        task.MarkAsCompleted();

        // Assert
        Assert.True(task.IsCompleted);
    }

    [Fact]
    public void TaskManager_ShouldUpdateTaskStatus()
    {
        // Arrange
        var taskManager = new TaskManager();
        var task = taskManager.CreateTask("Task");

        // Act
        task.MarkAsCompleted();

        // Assert
        var retrievedTask = taskManager.GetTask(task.Id);
        Assert.NotNull(retrievedTask);
        Assert.True(retrievedTask.IsCompleted);
    }



}
