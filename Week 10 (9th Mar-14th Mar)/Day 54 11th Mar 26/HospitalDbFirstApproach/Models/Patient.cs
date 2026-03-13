using System;
using System.Collections.Generic;

namespace HospitalDbFirstApproach.Models;

public partial class Patient
{
    public int PatientId { get; set; }

    public string? FullName { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? ContactNumber { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
