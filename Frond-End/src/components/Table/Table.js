import React from 'react'

import { Link } from 'react-router-dom'
import { useSelector } from 'react-redux'

import { FaPlus } from 'react-icons/fa'
import { FaSearch } from 'react-icons/fa'

import styles from './Table.module.css'

export default function Table({ data }) {
	const { theme } = useSelector(state => state.theme)

	if(data.rows.length === 0) {
		return (
			<>
				<h3>There is no data!</h3>
				<br />
				{data.createBtnUrl && <Link to={data.createBtnUrl}>create one</Link>}
			</>
		)
	}

  const keys = Object.keys(data.rows[0])

  return (
		<div className={`${styles.container} ${theme === 'dark' && styles.dark}`}>
			<h3 className="section-title">{data.title}</h3>
			<span className="line"></span>
			<div className={styles.btnArea}>
				{data.createBtnUrl && (
					<Link className={styles.createBtn} to={data.createBtnUrl}>
						<FaPlus />
					</Link>
				)}
				{data.searchBtnUrl && (
					<div className={styles.searchArea}>
						<input type='text' />
						<button className={styles.searchBtn}>
							<FaSearch />
						</button>
					</div>
				)}
			</div>
			<div className={styles.tableContainer}>
				<table className={`${styles.table} ${theme === 'dark' && styles.dark}`}>
				<thead>
					<tr>
						{data.headings.map(heading => (
							<th key={heading}>{heading}</th>
						))}
						<th>Operations</th>
					</tr>
				</thead>
				<tbody>
					{data.rows.map((row, idx) => (
						<tr key={idx}>
							{keys.map(key => (
								<td key={key}>{row[key]}</td>
							))}
							<td className={styles.operations}>
								{data.operations?.view && (
									<Link to={`${data.operations.view}/${row.id}/view`} className={styles.viewBtn}>View</Link>
								)}
								{data.operations?.edit && (
									<Link to={`${data.operations.edit}/${row.id}/edit`} className={styles.editBtn}>Edit</Link>
								)}
								{data.operations?.delete && (
									<button className={styles.deleteBtn} onClick={() => data.operations.delete(row.id)}>Delete</button>
								)}
							</td>
						</tr>
					))}
				</tbody>
			</table>
			</div>
		</div>
	)
}
