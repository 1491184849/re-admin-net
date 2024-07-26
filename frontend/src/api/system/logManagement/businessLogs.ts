import { ApplicationResult, PagedResult } from "#/data";
import request from "@/request";

export interface BusinessLogDto {
  id: string;
  userName: string;
  ip: string;
  address: string;
  os: string;
  browser: string;
  operationMsg: string;
  isSuccess: boolean;
  creationTime: string;
  url: string;
  action: string;
  httpMethod: string;
  nodeName: string;
  millSeconds: string;
}

/**
 * 业务日志
 * @param params
 * @returns
 */
export function getBusinessLogList(params: any) {
  return request.get<any, ApplicationResult<PagedResult<BusinessLogDto>>>(
    "adm/business-log/list",
    { params: params }
  );
}
