import request from "@/request";
import { ApplicationResult } from "#/data";

/**
 * 添加员工
 * @param data
 * @returns
 */
export function addEmployee(data: any) {
  return request.post<any, ApplicationResult<any>>(
    "/adm/employee/add",
    data
  );
}

/**
 * 员工列表
 * @param params
 * @returns
 */
export function getEmployeeList(params: any) {
  return request.get<any, ApplicationResult<Array<any>>>(
    "/adm/employee/list",
    { params: params }
  );
}

/**
 * 更新员工
 * @param data
 * @returns
 */
export function updateEmployee(data: any) {
  return request.put<any, ApplicationResult<any>>(
    "/adm/employee/update",
    data
  );
}

/**
 * 删除员工
 * @param id
 * @returns
 */
export function deleteEmployee(id: string) {
  return request.delete<any, ApplicationResult<any>>(
    "/adm/employee/delete/" + id
  );
}