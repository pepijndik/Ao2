"user strict";
const DB = require("./db");

class Helper {
  constructor(app) {
    this.db = DB;
  }

  async userNameCheck(username) {
    return await this.db.query(
      `SELECT count(username) as count FROM user WHERE LOWER(username) = ?`,
      `${username}`
    );
  }

  async registerUser(params) {
    try {
      return await this.db.query(
        "INSERT INTO user (`username`,`password`,`online`) VALUES (?,?,?)",
        [params["username"], params["password"], "Y"]
      );
    } catch (error) {
      console.error(error);
      return null;
    }
  }

  async loginUser(params) {
    try {
      return await this.db.query(
        `SELECT id FROM user WHERE LOWER(username) = ? AND password = ?`,
        [params.username, params.password]
      );
    } catch (error) {
      return null;
    }
  }

  async userSessionCheck(userId) {
    try {
      const result = await this.db.query(
        `SELECT online,username FROM user WHERE id = ? AND online = ?`,
        [userId, "Y"]
      );
      if (result !== null) {
        return result[0]["username"];
      } else {
        return null;
      }
    } catch (error) {
      return null;
    }
  }
}
module.exports = new Helper();
