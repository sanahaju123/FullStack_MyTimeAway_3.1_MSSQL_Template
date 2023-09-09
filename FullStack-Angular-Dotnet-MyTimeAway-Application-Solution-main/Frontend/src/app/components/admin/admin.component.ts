import { Component, OnInit } from '@angular/core';
import { LeaveService } from '../../services/leave.service';
import { Leave } from '../../models/leave.model';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {
  leaveApplications: Leave[] = [];

  constructor(private leaveService: LeaveService) { }

  ngOnInit() {
    this.fetchLeaveApplications();
  }

  fetchLeaveApplications() {
    this.leaveService.getAllLeaves().subscribe(
      (leaves) => {
        console.log(leaves);
        this.leaveApplications = leaves;
        console.log(this.leaveApplications);
      },
      (error) => {
        console.error('Error fetching leave applications:', error);
      }
    );
  }

  cancelLeave(application: Leave) {
    this.leaveService.cancelLeaveRequest(application.id).subscribe(
      () => {
        this.fetchLeaveApplications();
      },
      (error) => {
        console.error('Error canceling leave application:', error);
      }
    );
  }

  approveLeave(application: Leave) {
    this.leaveService.approveLeaveRequest(application.id).subscribe(
      () => {
        this.fetchLeaveApplications();
      },
      (error) => {
        console.error('Error canceling leave application:', error);
      }
    );
  }

  rejectLeave(application: Leave) {
    this.leaveService.rejectLeaveRequest(application.id).subscribe(
      () => {
        this.fetchLeaveApplications();
      },
      (error) => {
        console.error('Error rejecting leave application:', error);
      }
    );
  }
}
